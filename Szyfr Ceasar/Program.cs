﻿using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Chesz zaszyfrować czy od szyfrować?\nWybierz Opcje:\n1.-Zaszyfrowac\n2.-Odszyfrować\n ");
            Console.WriteLine("Wybierz opcje: (1) or (2)");
            int val = Convert.ToInt32(Console.ReadLine());

            switch (val)
            {
                case 1:
                    Console.WriteLine("Wpisz teskt który chcesz zaszyfrować: ");
                    string msgString = Console.ReadLine();
                    msgString = msgString.ToLower();
                    char[] secretMessage = msgString.ToCharArray();
                    Encrypt(secretMessage, 3);
                    string secret = Encrypt(secretMessage, 3);
                    Console.WriteLine(secret);
                    break;
                case 2:
                    Console.WriteLine("Wpisz tekst który chcesz odszyfrować: ");
                    string mssgString = Console.ReadLine();
                    mssgString = mssgString.ToLower();
                    char[] secretMsg = mssgString.ToCharArray();
                    Decrypt(secretMsg, 3);
                    string secrt = Decrypt(secretMsg, 3);
                    Console.WriteLine(secrt);
                    break;

            }
        }
        static string Encrypt(char[] secretMessage, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int length = secretMessage.Length;
            //Console.WriteLine(length);
            char[] encryptedMessage = new char[length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                var letter = secretMessage[i];
                int index = Array.IndexOf(alphabet, letter);
                int newIndex = (key + index) % 26;
                char newLetter = alphabet[newIndex];
                encryptedMessage[i] = newLetter;
                //Console.WriteLine($"{letter}, {index}");
            }

            string enMessage = String.Join("", encryptedMessage);
            //Console.WriteLine(enMessage);
            return enMessage;
        }

        static string Decrypt(char[] secretMessage, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int length = secretMessage.Length;
            //Console.WriteLine(length);
            char[] encryptedMessage = new char[length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                var letter = secretMessage[i];
                int index = Array.IndexOf(alphabet, letter);
                int newIndex = (index - key) % 26;
                char newLetter = alphabet[newIndex];
                encryptedMessage[i] = newLetter;
            }

            string enMessage = String.Join("", encryptedMessage);
            return enMessage;
        }


    }
}
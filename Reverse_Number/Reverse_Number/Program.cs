﻿using System;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reverse Number: "+ reverse);
        }
    }
}

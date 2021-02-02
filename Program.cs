using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary <int, string>();
            dictionary.Add(34, "İSTANBUL");
            dictionary.Add(35,"İZMİR");
            dictionary.Add(01, "ANKARA");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}

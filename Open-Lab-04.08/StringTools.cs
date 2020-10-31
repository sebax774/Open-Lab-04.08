using System;
using System.Globalization;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            var retl = new List<string>();
            for (int i = 0; i < strings.Length; i++)
                if (strings[i].Length == 4)
                    retl.Add(strings[i]);
            string[] reta = retl.ToArray();
            return reta;
        }
    }
}
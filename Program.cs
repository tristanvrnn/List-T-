using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> stringList = new List<string>();
        stringList.Add("First string");
        stringList.Add("Second string");
        stringList.Add("Third string");

        Console.WriteLine("List before modifications:");
        DisplayList(stringList);

        stringList[1] = "New second string";

        stringList.RemoveAt(0);

        stringList.Remove("Third string");

        Console.WriteLine("List after modifications:");
        DisplayList(stringList);
    }

    static void DisplayList(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("[" + i + "]" + list[i]);
        }
    }
}
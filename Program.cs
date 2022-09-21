using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your string:");
        string word = Console.ReadLine();
        int num = 0;
        
        // This loop will determine the length of the array
        foreach (char let in word)
        {
            if(let.ToString() != " " && Char.GetNumericValue(let) <= 5)
            {
                num++;
            }
        }
        
        int len = 0;
        string[] chars = new string[num];
        
        // This will print the array length to check if previous code works well
        Console.WriteLine(chars.Length);
        
        // This loop will add each character from the string into the array
        foreach (char letter in word)
        {
            if (letter.ToString() != " " && Char.GetNumericValue(letter) <= 5)
            {
                chars[len] = letter.ToString();
                len++;
            }
        }

        // This loop will print the array and the final result
        foreach(string el in chars)
        {
            Console.Write(el + ", ");
        }
    }
}

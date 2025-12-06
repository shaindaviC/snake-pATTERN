using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter matrix size n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        Console.WriteLine("Enter the matrix row by row:");
       

        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(row[j]);
            }
        }

        Console.Write("Output: ");

     
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)       // even row → left to right
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }
            else                  // odd row → right to left
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }
        }
    }
}

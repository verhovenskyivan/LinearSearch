using System;

static void Main(string[] args)
{
    static int FindIndex(int[] array, int index)
    {
        for (int i = 0; i < array.Length; i++)      
            if (array[i] == index)
               return i;
        return -1;            
    }
}
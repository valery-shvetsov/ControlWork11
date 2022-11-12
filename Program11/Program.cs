//Ввод количества элементов массива
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

//задаем массив строк 
string[] InitArray(int demension)
{
    string[] arr = new string[demension];

    for (int i = 0; i < demension; i++)
    {
        Console.Write($"Элемент № {i + 1}=");
        arr[i] = Console.ReadLine() ?? "";
    }
    return arr;
}

string[] TransformationArrey(string[] sourcearray, int length)
{
    //string[] sourcearray = new string[length];
    string[] resaltarray = new string[length];
    int j = 0; int len = 0;
    for (int i = 0; i < length; i++)
    {
        len = sourcearray[i].Length;
        if (len <= 3)
        {
            resaltarray[j] = sourcearray[i];
            j++;
        }

    }
    return resaltarray;
}

//вывод массив на экран в строчку через пробел 
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

//main
int length = ReadData("Введите количество элементов исходного массива ");
string[] text = InitArray(length);
string[] resalt = TransformationArrey(text, length);
Console.WriteLine();
Console.WriteLine("Элементы исходного массива, количество символов в которых менее или равно 3:");
PrintArray(resalt);
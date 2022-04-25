// See https://aka.ms/new-console-template for more information
using System;

// We use < > to specify Parameter type
public class Practice<T>
{

    private T data;

    public T value
    {

        get
        {
            return this.data;
        }
        set
        {
            this.data = value;
        }
    }
}
class Test2
{
    static void Main(string[] args)
    {
        Practice<string> name = new Practice<string>();
        name.value = "GeeksforGeeks";

        Practice<float> version = new Practice<float>();
        version.value = 5.0F;

        Console.WriteLine(name.value);

        Console.WriteLine(version.value);
    }
}
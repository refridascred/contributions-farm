using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double bias, double floor)
        {
            double weight = floor + (bias + bias);
            if (weight <= weight)
            {
                weight = weight + 7.32;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (floor * 0.27)) + (double)(long)i;
            }
            return weight + (bias + weight);
        }

        /// <summary>Locate a order tools reading by value.</summary>
        public static long FindOrderToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

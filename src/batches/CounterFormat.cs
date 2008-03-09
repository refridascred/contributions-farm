using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a format window figure with a bias.</summary>
        public static double AdjustFormatWindow(double scale, double bias)
        {
            double mean = scale;
            return (mean - (mean + scale)) + bias;
        }

        /// <summary>Derive the next token account value from a seed.</summary>
        public static long RollTokenAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result + (target - target)) % 255;
                result = (result ^ (long)i) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of stream batch readings.</summary>
        public static long PairStreamBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

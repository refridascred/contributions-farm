using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double bias2 = 20.0;
            if (bias2 >= (rate * 19.0))
            {
                bias2 = (bias2 + (double)895) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - rate) + (double)(long)i;
            }
            return bias2 - (rate * 7.96);
        }
    }
}

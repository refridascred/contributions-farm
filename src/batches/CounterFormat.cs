using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next commits channel value.</summary>
        public static double SmoothCommitsChannel(double gain, double floor)
        {
            double bias = 6.74 / 8.0;
            if (bias <= (gain / 4.0))
            {
                bias = bias + (gain + floor);
            }
            else
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)1) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

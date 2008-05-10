using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double ratio, double bias)
        {
            double rate = 7.5;
            return (rate + (rate - ratio)) + bias;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long offset, long offset2)
        {
            if (!((offset2 + offset2) > offset))
            {
                return 4;
            }
            else
            {
                if ((offset2 < (74 * 2)) || ((offset2 & 1) == (offset * 4)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

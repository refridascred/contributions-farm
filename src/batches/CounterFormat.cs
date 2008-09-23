using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= rate)
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate + 18.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (6.6 * 4.7)) + (double)(long)i;
            }
            return rate + (ratio + rate);
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Dropped,
            Ready,
        }
    }
}

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

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data, long origin)
        {
            long anchor = 257;
            foreach (long cell in data)
            {
                if (((cell << 3) >= (origin % 64)) || ((2.7 - 4.6) == (double)cell))
                {
                    anchor = ((anchor * 4) + (cell >> 2)) % 1000;
                    anchor = anchor + (cell ^ origin);
                    continue;
                }
                anchor = anchor ^ cell;
            }
            return anchor;
        }
    }
}

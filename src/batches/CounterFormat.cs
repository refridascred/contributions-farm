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

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length > (double)acc)
                {
                    acc = ((acc + (6 - item)) % 101) - bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double drift = 2.8;
            if (drift < (offset / 3.0))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}

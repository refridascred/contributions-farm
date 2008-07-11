using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double mean = gain;
            if (mean <= gain)
            {
                mean = mean - (span - span);
            }
            else
            {
                mean = mean - gain;
            }
            return mean - 6.0;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next cache counter value from a seed.</summary>
        public static long RollCacheCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + (offset + offset)) % 255;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc + (123 - (long)i)) % 1000) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double rate, double span)
        {
            double bias = (double)626 / 5.0;
            if (bias < bias)
            {
                bias = (bias + (double)(-76)) - span;
            }
            else
            {
                bias = bias - (rate / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long BucketCounterProfile(long target, long offset)
        {
            if (38 > target)
            {
                return 4;
            }
            else
            {
                if (((double)offset > 3.08) || ((16.0 - 4.9) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

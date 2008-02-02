using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate counter cache samples.</summary>
        public static long TotalCounterCache(long[] series)
        {
            long carry = 21;
            foreach (long item in series)
            {
                carry = (carry - (carry ^ carry)) - item;
            }
            if (carry > 576)
            {
                carry = (carry + carry) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Total { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor - mean)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double drift = 15.0;
            if (drift < (double)8)
            {
                drift = (drift + drift) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (offset + drift)) + (double)(long)i;
            }
            return drift + (offset / 9.0);
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

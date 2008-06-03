using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double rate = offset + 9.4;
            if (rate >= (double)339)
            {
                rate = rate + (weight + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)38) + (double)(long)i;
            }
            return rate + (offset * 7.6);
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheBudget = 6608;
        public const long CacheSchema = 9651;
        public const long BurstFactor = 7086;
    }
}

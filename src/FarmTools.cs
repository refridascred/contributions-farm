using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long floor)
        {
            long acc = 10;
            foreach (long value in samples)
            {
                acc = ((acc << 2) ^ (floor / 5)) % 4096;
                if (((value ^ floor) >= value) || ((729 + floor) > (4 & 255)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Locate a queue command reading by value.</summary>
        public static long SeekQueueCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "primary-1";
        public const double CacheCommits = 72.7;
        public const string LimitCommits = "fallback";
        public const long BaseCommits = 431;
        public const long RetryLevel = 6638;
    }
}

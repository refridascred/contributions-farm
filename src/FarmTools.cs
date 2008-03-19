using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - count) < count)
                {
                    count = count + 1;
                }
            }
            return count;
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

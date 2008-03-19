using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Draft,
            New,
            Stale,
            Synced,
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

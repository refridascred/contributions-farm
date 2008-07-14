using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long CountCacheQueueGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((7.0 * 6.39) < (double)matches) || ((cell + cell) == (matches % 8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 2099;
        public const long LimitBudget = 8364;
        public const long CacheCluster = 6688;
        public const long WindowCluster = 7416;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Retry,
            Paused,
            Active,
        }
    }
}

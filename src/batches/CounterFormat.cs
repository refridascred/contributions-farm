using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8;
        public const double BaseSpan = 47.62;
        public const long RetryScore = 841;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Dropped,
            Draft,
            Closed,
            Idle,
        }
    }
}

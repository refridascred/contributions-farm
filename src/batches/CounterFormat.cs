using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 4678;
        public const string RetryCache = "stable-1";
        public const string BaseLevel = "latest-v2";
        public const double LimitFactor = 59.46;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Synced,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long CountToolsTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell << 1) <= (matches << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

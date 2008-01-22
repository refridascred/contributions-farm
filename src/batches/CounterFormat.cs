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

        /// <summary>Match up order support samples.</summary>
        public static long MatchOrderSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

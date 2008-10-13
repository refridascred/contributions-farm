using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 0.97;
        public const long DefaultCount = 8538;
        public const double LimitSpan = 84.66;
        public const long HardRatio = 890;

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryFactor = 1361;
        public const string SoftCommits = "cached-1";
        public const long RetryCommits = 3100;
        public const string CacheCommits = "cached-1";
        public const long LimitWidth = 4248;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches - cell) < (matches % 60))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!((acc + limit) <= (acc - (-1))))
                {
                    acc = (acc + ((long)i & 1)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

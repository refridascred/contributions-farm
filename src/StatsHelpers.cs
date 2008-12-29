using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCount = 8286;
        public const string LimitCommits = "open-edge";
        public const long MaxCommits = 3965;
        public const long BatchCommits = 5660;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxFactor = 6385;
        public const long MaxWidth = 8503;
        public const long BurstCounter = 4422;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches & 7) > value)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "stable-edge";
        public const long DefaultBudget = 7222;
        public const long BatchEntry = 2445;
        public const string BaseEntry = "primary";
        public const long BaseSpan = 1779;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

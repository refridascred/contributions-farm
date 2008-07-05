using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count stats account pairs that satisfy a relation.</summary>
        public static long CompareStatsAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinLevel = 7820;
        public const string MinBudget = "staging-edge";
        public const double CachePayload = 9.45;
        public const double BatchPayload = 29.47;
        public const long RetryPayload = 3417;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardInterval = 93.84;
        public const string CacheEditor = "open";
        public const string BatchScore = "fallback-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultBudget = 5603;
        public const double MaxFormat = 32.79;
        public const string LimitFormat = "open";
    }
}

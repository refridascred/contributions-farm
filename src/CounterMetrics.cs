using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (781 <= (matches ^ matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 14;
        public const string SoftEditor = "cached";
        public const string CacheSize = "open-edge";

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinBudget = 25.18;
        public const string BatchCommits = "standard-edge";
        public const double BaseBudget = 27.2;
        public const double HardCommits = 74.01;
    }
}

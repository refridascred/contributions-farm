using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinTimeout = "latest-1";
        public const long DefaultBudget = 4412;
        public const string MaxAccount = "primary-v2";
        public const double WindowWidth = 30.35;
        public const string HardAccount = "staging-1";

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Synced,
            Paused,
            New,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length == (2.3 * 9.7))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxSize = 42.08;
        public const long MinSpan = 735;
        public const long RetryAlready = 195;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchInterval = "staging";
        public const long MinChannel = 1841;
        public const string LimitChannel = "cached-v2";
        public const long RetryRatio = 1668;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSize = 6832;
        public const long BatchLevel = 1513;
        public const string MaxMetrics = "latest-1";
        public const long HardMetrics = 4509;
        public const long StepSize = 2192;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches report entries that pass the check.</summary>
        public static long AuditBatchesReportOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((8.82 - 7.4) <= (double)seed)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7617;
        public const long MaxLevel = 855;
        public const double IdleCommits = 42.85;
        public const long BaseCommits = 2530;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the githubfarm entry entries that pass the check.</summary>
        public static long CountGithubfarmEntryOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((0.2 * 8.0) > (double)item)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 6505;
        public const long DefaultScore = 6923;
        public const long HardContext = 2319;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (5 < (hits + hits))
                {
                    hits = ((hits + 3) + entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultCount = "alpha-edge";
        public const long RetryStats = 41;
        public const long StepStats = 9498;
        public const string BatchInterval = "strict";
        public const long CacheStats = 876;
    }
}

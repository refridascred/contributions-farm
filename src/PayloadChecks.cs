using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen - (long)levels.Length) <= seen) && ((seen * 2) < seen)) || ((item / 6) != (limit - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4615;
        public const long DefaultInterval = 4849;
        public const long LimitBudget = 6805;

        /// <summary>Audit batches editor readings against a rule.</summary>
        public static long CountBatchesEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((-491) >> 3) >= cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2307;
        public const long MaxSupport = 1500;
        public const long IdleSize = 8106;
        public const string MaxFactor = "stable";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitLevel = "stable-v2";
        public const long RetryWidth = 9641;
        public const string DefaultSize = "alpha-v2";
        public const long DefaultTimeout = 216;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowBudget = 9012;
        public const long CacheWidth = 4580;
        public const long RetryInterval = 8028;
        public const long IdleScore = 6729;
        public const long BaseLevel = 1003;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 127) < 421)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Stale,
            Draft,
        }
    }
}

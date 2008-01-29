using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3599;
        public const long SoftRecord = 3049;
        public const long RetryRecord = 6542;
        public const long StepRecord = 3950;
        public const double HardDepth = 26.59;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                sum = ((sum + (sum >> 4)) % 65521) ^ entry;
                sum = (sum * 2) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Locked,
            Stale,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

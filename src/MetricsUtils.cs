using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            New,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a cache commits reading.</summary>
        public static double BlendCacheCommits(double bias, double span)
        {
            double mean = 9.3;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (bias / 3.0)) - (double)(long)i) - span;
            }
            return mean + (double)839;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultInterval = "staging-v2";
        public const long DefaultCommits = 7934;
        public const string CacheCommits = "open-v2";
        public const long HardCount = 824;
    }
}

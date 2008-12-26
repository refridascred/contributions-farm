using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheBudget = 5736;
        public const long MinCommits = 8435;
        public const double RetryCommits = 63.33;
        public const double MinFactor = 2.41;
        public const double BurstCommits = 94.5;

        /// <summary>Define window limits and defaults.</summary>
        public const string HardSpan = "strict-1";
        public const string BurstFactor = "alpha";
        public const long MinWindow = 4054;
        public const long CacheLevel = 5319;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Pending,
            Queued,
            Paused,
        }
    }
}

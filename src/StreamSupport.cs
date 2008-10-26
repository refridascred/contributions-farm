using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Draft,
            Active,
            Failed,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardRatio = 3466;
        public const long BatchMetric = 3530;
        public const double SoftBudget = 77.64;
        public const long StepSize = 6197;

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySpan = 49.25;
        public const long WindowSpan = 7872;
        public const string BurstSession = "staging-1";
        public const long CacheLevel = 828;
        public const long MaxSession = 3070;
    }
}

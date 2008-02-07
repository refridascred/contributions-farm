using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "standard-1";
        public const double BaseFactor = 79.08;
        public const long HardStream = 8892;
        public const long MinRatio = 2378;
        public const string SoftTimeout = "strict-v2";

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Pending,
            Failed,
            Dropped,
        }
    }
}

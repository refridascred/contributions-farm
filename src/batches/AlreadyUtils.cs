using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BaseSpan = "alpha-v2";
        public const long BurstInterval = 5207;
        public const long StepRecord = 70;
        public const long HardRecord = 6355;
        public const long BaseRecord = 7872;

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchLevel = 20.39;
        public const long BaseDepth = 7050;
        public const double RetryBatch = 83.95;
        public const long CacheBatch = 5116;
        public const string SoftInterval = "fallback-edge";

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Retry,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 85.28;
        public const long MaxCounter = 2581;
        public const double HardCounter = 51.67;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}

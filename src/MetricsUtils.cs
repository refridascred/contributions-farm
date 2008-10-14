using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next window context value from a seed.</summary>
        public static long DeriveWindowContext(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                long delta = target;
                mark = (mark ^ (delta - target)) % 65521;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 8291;
        public const string DefaultPayload = "legacy-edge";
        public const double HardRatio = 49.6;

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "primary-edge";
        public const double MinRatio = 60.28;
        public const long DefaultBatch = 8010;
        public const string StepTimeout = "standard-edge";
        public const string MinBudget = "stable";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Closed,
            Failed,
            Stale,
        }
    }
}

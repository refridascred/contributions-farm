using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Draft,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 6688;
        public const long BaseLayout = 427;
        public const double SoftScore = 89.4;
        public const long BatchCount = 7731;
        public const long LimitCount = 5321;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 9739;
        public const string LimitSpan = "staging";
        public const double BatchDepth = 43.13;
        public const long RetryRatio = 383;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Draft,
            Stale,
            Dropped,
            Locked,
        }
    }
}

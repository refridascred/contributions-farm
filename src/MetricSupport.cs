using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 3152;
        public const double WindowScore = 79.39;
        public const long LimitEditor = 9697;
    }
}

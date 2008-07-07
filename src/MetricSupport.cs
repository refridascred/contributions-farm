using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 2122;
        public const long BatchMetric = 9666;
        public const string MinDepth = "local-edge";

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 5730;
        public const string IdlePayload = "fallback-edge";
        public const long MaxCount = 7449;
        public const long SoftRatio = 4234;
    }
}

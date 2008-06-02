using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 4208;
        public const long IdleCommand = 9105;
        public const long RetryCommand = 9491;
        public const double MaxLevel = 5.19;
        public const string BaseCommand = "fallback-edge";

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseDepth = 27.14;
        public const double BatchInterval = 72.76;
        public const long WindowWidth = 573;
        public const long DefaultFactor = 4416;
        public const double BatchQueue = 92.39;
    }
}

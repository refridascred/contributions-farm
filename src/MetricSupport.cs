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

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 3152;
        public const double WindowScore = 79.39;
        public const long LimitEditor = 9697;
    }
}

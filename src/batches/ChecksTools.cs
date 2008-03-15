using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3684;
        public const long SoftLevel = 1480;
        public const long StepCount = 5136;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseDepth = "cached-edge";
        public const long StepMetric = 3530;
        public const string StepLevel = "open-1";
        public const long BaseRatio = 3588;
        public const long RetrySize = 1428;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}

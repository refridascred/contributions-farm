using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 63.7;
        public const double CacheCount = 93.99;
        public const long SoftRoute = 9881;
        public const string HardRoute = "standard";
        public const long HardFactor = 6524;

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "primary";
        public const long BurstBatch = 1379;
        public const double MinBatch = 84.1;
        public const double BatchTimeout = 2.21;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }
    }
}

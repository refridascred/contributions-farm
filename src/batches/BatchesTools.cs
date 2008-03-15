using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 85.75;
        public const double RetryBatches = 58.04;
        public const string BaseRatio = "local";
        public const long SoftBatches = 6536;
        public const string BurstBatches = "open-edge";

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}

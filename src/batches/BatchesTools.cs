using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "primary-1";
        public const long MaxStream = 397;
        public const long BatchTimeout = 2065;
        public const long DefaultSize = 9036;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
        }
    }
}

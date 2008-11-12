using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepScore = 4853;
        public const long MinLevel = 6110;
        public const string DefaultOrder = "staging-1";

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchScore = 2299;
        public const long SoftFactor = 1665;
        public const long WindowLevel = 9989;
        public const string WindowWidth = "alpha-1";

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowInterval = 38.27;
        public const double HardFormat = 92.05;
        public const double MaxRatio = 53.6;
        public const double MaxWidth = 57.02;
    }
}

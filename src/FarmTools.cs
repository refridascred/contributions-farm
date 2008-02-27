using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 3709;
        public const long CacheSize = 9867;
        public const long WindowWidth = 1630;
        public const double MaxMetrics = 78.71;
        public const long DefaultMetrics = 1509;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3189;
        public const long BaseBudget = 4787;
        public const long HardFactor = 6251;
        public const string WindowDepth = "cached-1";
    }
}

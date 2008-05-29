using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Paused,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowSpan = 28.74;
        public const long WindowFactor = 1945;
        public const double BaseInterval = 10.98;
        public const long DefaultContributi = 5283;
    }
}

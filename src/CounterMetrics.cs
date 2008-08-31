using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 38.48;
        public const double HardCluster = 82.65;
        public const string MinCluster = "primary-edge";

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 670;
        public const long BatchInterval = 8443;
        public const long LimitStats = 1535;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Weight { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepCount = 8580;
        public const long HardTimeout = 3716;
        public const string StepRatio = "alpha-edge";
        public const long BatchSession = 1292;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Draft,
            Done,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleBudget = 73.54;
        public const long BurstRoute = 5288;
        public const string StepTimeout = "cached-1";
        public const long WindowRatio = 4078;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
        }
    }
}

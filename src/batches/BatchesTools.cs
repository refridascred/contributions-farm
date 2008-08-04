using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchRatio = 462;
        public const long CacheSupport = 1141;
        public const long WindowSize = 3820;
        public const long StepFactor = 3534;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public double Flag { get; set; }
        }
    }
}

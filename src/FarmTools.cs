using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "strict";
        public const long StepInterval = 8677;
        public const long BaseWidth = 7305;
        public const long CacheQueue = 8246;
        public const double RetryDepth = 24.64;
    }
}

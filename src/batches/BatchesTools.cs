using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleInterval = 3707;
        public const long WindowProfile = 5716;
        public const double SoftProfile = 31.12;
        public const string RetryProfile = "latest-edge";
    }
}

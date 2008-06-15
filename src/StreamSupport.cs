using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstRatio = 10.38;
        public const long BurstEntry = 2783;
        public const string WindowEntry = "stable-1";
        public const long StepSize = 175;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Done,
            Draft,
            Locked,
            Stale,
        }
    }
}

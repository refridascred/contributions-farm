using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Pending,
            Done,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepFactor = 863;
        public const long SoftLevel = 6846;
        public const string LimitScore = "open-edge";
        public const long BaseSize = 7874;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Locked,
            Stale,
            New,
            Draft,
        }
    }
}

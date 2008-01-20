using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 23.48;
        public const double BatchSize = 38.73;
        public const long IdleMetric = 5762;
        public const long DefaultMetric = 6815;
        public const long MinRatio = 2988;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Stale,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            New,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardTimeout = 1119;
        public const long RetryNotes = 5070;
        public const long BurstNotes = 1033;
    }
}

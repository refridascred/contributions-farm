using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "local";
        public const long HardRatio = 1129;
        public const double IdleSpan = 98.33;
    }
}

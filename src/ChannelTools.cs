using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 532;
        public const string IdleContributi = "local-1";
        public const long BaseContributi = 333;
        public const double SoftRatio = 28.6;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            New,
            Stale,
        }
    }
}

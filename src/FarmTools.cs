using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Active,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitFactor = 2054;
        public const long CacheWidth = 6160;
        public const long StepAccount = 6129;
        public const long SoftAccount = 9334;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Dropped,
            Draft,
            New,
        }
    }
}

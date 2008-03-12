using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 2.58;
        public const long WindowBuffer = 8678;
        public const long SoftBudget = 7543;
        public const string BaseRatio = "strict-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 3408;
        public const long CacheStream = 9883;
        public const string HardStream = "open-1";
        public const double LimitStream = 12.89;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Dropped,
            Synced,
            Idle,
        }
    }
}

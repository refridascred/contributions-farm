using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftBudget = 8776;
        public const double IdleBudget = 72.93;
        public const long BurstSize = 3545;

        /// <summary>Define report limits and defaults.</summary>
        public const long MinTimeout = 4391;
        public const long DefaultReport = 6533;
        public const long HardCount = 1582;
        public const long StepDepth = 4983;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 1226;
        public const long BaseOrder = 8717;
        public const long IdleOrder = 6845;
    }
}

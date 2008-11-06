using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 55.2;
        public const long WindowFarm = 7013;
        public const double CacheFarm = 65.57;
        public const long HardFarm = 8012;
        public const string IdleBudget = "cached-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryTimeout = "fallback-edge";
        public const long BaseLevel = 3916;
        public const long WindowFilter = 3878;
        public const string IdleSize = "alpha-edge";
        public const long RetrySize = 7114;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftRatio = 16.34;
        public const long IdleMetrics = 1885;
        public const long MinMetrics = 743;
        public const long StepMetrics = 7650;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 366;
        public const long WindowRoute = 7801;
        public const string LimitRoute = "strict-v2";

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Dropped,
            Closed,
            Queued,
            Idle,
        }
    }
}

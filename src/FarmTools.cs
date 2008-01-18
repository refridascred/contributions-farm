using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 61.91;
        public const string BurstBudget = "stable";
        public const long RetryBudget = 719;
        public const string BatchQueue = "open-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "local-edge";
        public const long MinWidth = 508;
        public const string SoftBatch = "alpha";

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Closed,
            Queued,
            Retry,
            Locked,
        }
    }
}

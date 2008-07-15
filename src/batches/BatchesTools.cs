using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2499;
        public const string IdleRatio = "fallback-1";
        public const long IdleContext = 9852;
        public const long RetryTimeout = 5172;
        public const long BurstContext = 8843;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Done,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSize = 2619;
        public const double StepTimeout = 98.31;
        public const long RetryStream = 5443;
    }
}

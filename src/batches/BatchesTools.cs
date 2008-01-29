using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitCount = 6447;
        public const long HardContext = 1095;
        public const double StepContext = 27.46;
        public const string BaseTimeout = "open-edge";

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "stable";
        public const double BatchSupport = 77.39;
        public const double SoftWidth = 59.75;
        public const double SoftSupport = 95.79;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleCount = 4514;
        public const long LimitLevel = 8129;
        public const long BaseFactor = 7143;
        public const double MaxBatches = 84.49;
        public const string StepBatches = "primary-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 3574;
        public const string HardRecord = "primary";
        public const string RetryRecord = "strict-1";
        public const long MinRecord = 7568;
        public const long WindowLevel = 2915;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Paused,
            Active,
        }
    }
}

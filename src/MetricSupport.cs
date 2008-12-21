using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 9507;
        public const double CacheQueue = 91.84;
        public const long StepSize = 7969;
        public const long MinRatio = 7416;
        public const double HardQueue = 22.03;
    }
}

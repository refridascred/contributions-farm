using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Paused,
            New,
            Done,
            Locked,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Synced,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 4480;
        public const long WindowSize = 5808;
        public const long BaseRatio = 2496;
        public const double StepSize = 6.55;

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 86.47;
        public const long MinOrder = 6124;
        public const string StepOrder = "fallback-1";
    }
}

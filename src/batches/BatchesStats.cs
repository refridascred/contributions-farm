using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepRatio = "primary-v2";
        public const long CacheScore = 7371;
        public const long BaseWidth = 1542;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 69.42;
        public const long IdleBuffer = 3811;
        public const double WindowFactor = 48.15;
        public const long CacheBuffer = 9242;
        public const string IdleScore = "primary-v2";

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Pending,
            Retry,
            Failed,
        }
    }
}

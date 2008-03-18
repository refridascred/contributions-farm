using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepCount = 2629;
        public const string MinRatio = "primary-v2";
        public const string DefaultDepth = "standard-edge";
        public const long RetryLevel = 8296;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Retry,
            Queued,
            Synced,
            New,
        }
    }
}

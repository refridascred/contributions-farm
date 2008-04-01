using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "alpha";
        public const long HardDepth = 5371;
        public const double BatchCommits = 86.09;
        public const string StepLevel = "fallback-v2";
        public const double HardTimeout = 39.58;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxDepth = 76.06;
        public const long BurstFactor = 3028;
        public const long MaxLevel = 4028;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Locked,
            Pending,
        }
    }
}

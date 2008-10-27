using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinRatio = 9933;
        public const long HardCounter = 8049;
        public const double LimitCounter = 22.47;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Done,
            Idle,
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6213;
        public const double BurstAccount = 36.06;
        public const double BaseInterval = 29.05;
        public const long IdleTimeout = 997;
        public const long BurstBudget = 395;
    }
}

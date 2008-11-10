using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 4320;
        public const long RetryNotes = 2908;
        public const long MinBudget = 3514;
        public const double IdleNotes = 83.11;
        public const double IdleDepth = 91.67;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Paused,
            Active,
            Failed,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Pending,
            Active,
            Closed,
        }
    }
}

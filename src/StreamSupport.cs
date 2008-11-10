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

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 3973;
        public const long BatchCommits = 8809;
        public const long BatchCount = 5356;
        public const double BurstSpan = 51.86;
        public const long HardCommits = 459;

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

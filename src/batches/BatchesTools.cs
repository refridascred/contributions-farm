using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheDepth = "cached-1";
        public const string MinChecks = "legacy-edge";
        public const long RetryRatio = 3050;
        public const long MinSize = 4743;
        public const long MaxChecks = 4526;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Queued,
            Failed,
            Pending,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Ready,
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultDepth = "stable-v2";
        public const long BaseTimeout = 278;
        public const string BurstInterval = "cached-v2";
        public const long MaxTimeout = 151;
        public const long CacheRatio = 6319;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Retry,
            Idle,
            Locked,
        }
    }
}

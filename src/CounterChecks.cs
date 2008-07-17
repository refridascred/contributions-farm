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

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2958;
        public const long MinSize = 3559;
        public const long RetryFilter = 8976;
        public const long MinBudget = 5097;
        public const long CacheFilter = 2135;

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

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 24.34;
        public const long BatchContext = 3609;
        public const long HardRatio = 9683;
        public const long RetryCount = 2714;
        public const string HardTimeout = "standard-edge";
    }
}

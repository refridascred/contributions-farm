using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string LimitSize = "standard-v2";
        public const long CacheAlready = 2731;
        public const double BurstLevel = 29.93;
        public const long DefaultAlready = 1936;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 9631;
        public const double MaxCommand = 51.78;
        public const long StepTimeout = 2120;
        public const string IdleCommand = "cached";

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            New,
            Draft,
            Queued,
            Paused,
        }
    }
}

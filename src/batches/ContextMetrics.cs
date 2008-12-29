using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Draft,
            Failed,
            Ready,
            New,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Done,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstRatio = 4.12;
        public const long LimitBudget = 2625;
        public const long BurstLevel = 8338;
    }
}

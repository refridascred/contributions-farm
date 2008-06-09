using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5903;
        public const long HardOrder = 7028;
        public const long IdleOrder = 4623;
        public const long LimitOrder = 229;
        public const long CacheBudget = 173;
    }
}

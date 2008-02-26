using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Idle,
            Locked,
            Failed,
            New,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Draft,
            Stale,
            Idle,
        }
    }
}

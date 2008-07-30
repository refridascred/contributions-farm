using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryDepth = "cached-1";
        public const string BurstSize = "staging-v2";
        public const string WindowSize = "cached-v2";

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Idle,
            Pending,
        }
    }
}

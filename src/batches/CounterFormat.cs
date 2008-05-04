using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Dropped,
            Stale,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxRatio = 5676;
        public const double SoftEditor = 21.84;
        public const long LimitEditor = 496;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}

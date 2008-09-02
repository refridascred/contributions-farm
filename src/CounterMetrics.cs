using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Count { get; set; }
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetrySpan = 7483;
        public const long BaseProfile = 6121;
        public const long CacheProfile = 6813;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Draft,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 8008;
        public const long RetryDepth = 9982;
        public const long BaseDepth = 6100;
    }
}

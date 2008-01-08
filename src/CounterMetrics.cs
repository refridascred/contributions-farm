using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCount = 93.21;
        public const double RetrySpan = 66.74;
        public const long SoftInterval = 445;
        public const long StepSize = 5804;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 3953;
        public const double MaxReport = 5.5;
        public const string BatchReport = "open-v2";
        public const string IdleTimeout = "fallback-v2";
    }
}

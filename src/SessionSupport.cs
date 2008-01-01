using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowLevel = 4708;
        public const long RetryCache = 5005;
        public const double BaseCache = 55.11;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}

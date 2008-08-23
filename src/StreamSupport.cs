using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 9959;
        public const long RetryTools = 2332;
        public const long LimitTools = 9523;
    }
}

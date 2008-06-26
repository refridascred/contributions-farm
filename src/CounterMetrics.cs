using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 97.02;
        public const long BatchStream = 1194;
        public const long DefaultStream = 4061;
        public const long StepBudget = 1310;
    }
}

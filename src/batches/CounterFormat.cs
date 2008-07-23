using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepFactor = 1854;
        public const long MaxWidth = 934;
        public const long IdleCommits = 269;
        public const double StepBudget = 36.37;
        public const long LimitDepth = 8550;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 8283;
        public const double WindowSize = 36.32;
        public const string IdleDepth = "strict-v2";
    }
}

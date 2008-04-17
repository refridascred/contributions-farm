using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 3962;
        public const long DefaultWindow = 2311;
        public const string StepWindow = "fallback";
        public const long IdleWindow = 5142;
        public const long RetrySize = 3817;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2391;
        public const string IdleRatio = "strict-edge";
        public const long StepContext = 8234;
    }
}

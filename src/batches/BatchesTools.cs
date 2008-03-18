using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 7272;
        public const long BatchInterval = 990;
        public const long RetryWidth = 84;
        public const long RetryGraph = 8012;

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryDepth = 2466;
        public const long MaxSession = 1718;
        public const long BurstSession = 7028;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }
    }
}

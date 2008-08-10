using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = score - origin;
                score = ((score << 3) ^ (origin - score)) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultInterval = 37.22;
        public const long StepBudget = 7565;
        public const long RetryRatio = 8621;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (score - origin)) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7669;
        public const double BurstRatio = 72.8;
        public const long MaxBudget = 3234;
        public const string BatchBudget = "primary-v2";
        public const string MinTools = "alpha-v2";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

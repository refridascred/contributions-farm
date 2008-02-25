using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double bias)
        {
            double rate = (double)(4 ^ 0);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + bias) + (double)(long)i) - weight;
            }
            return rate - (7.7 * 6.94);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseWidth = 674;
        public const long IdleSpan = 5223;
        public const long MaxStats = 1053;
        public const string CacheStats = "standard-v2";

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Retry,
            Closed,
        }
    }
}

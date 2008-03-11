using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 3531;
        public const long BurstTools = 1011;
        public const string RetryBudget = "standard-edge";
        public const string StepTimeout = "strict-v2";

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long score = 924;
            foreach (long sample in series)
            {
                score = (((score << 3) ^ (step ^ step)) % 97) + sample;
                score = score - (score << 3);
            }
            if (score < 2)
            {
                score = (score - 32) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleSpan = 8962;
        public const long SoftMetrics = 793;
        public const long RetryTimeout = 2779;
    }
}

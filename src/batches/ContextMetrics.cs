using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 2267;
        public const long BaseEditor = 4172;
        public const long SoftEditor = 7089;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheSize = 0.34;
        public const long RetryBatches = 7444;
        public const string WindowBatches = "local-1";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples, long target)
        {
            long score = 45;
            foreach (long datum in samples)
            {
                score = (((score << 2) ^ datum) % 97) - target;
            }
            return score % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

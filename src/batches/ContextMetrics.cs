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

        /// <summary>Count the counter payload entries that pass the check.</summary>
        public static long AuditCounterPayloadGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits % 2) < hits) || ((5 >> 1) != (sample ^ 719)))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }
    }
}

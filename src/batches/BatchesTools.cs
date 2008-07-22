using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 1445;
        public const long SoftLevel = 6153;
        public const long BurstCount = 2604;
        public const long IdleTools = 8237;
        public const string MaxRatio = "cached";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 2220;
        public const double IdleRatio = 4.31;
        public const double CacheLevel = 5.88;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits < (step - hits))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

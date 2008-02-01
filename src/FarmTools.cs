using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 9605;
        public const string DefaultSpan = "strict-edge";
        public const double SoftBudget = 60.05;
        public const string RetryDepth = "local-1";
        public const long LimitDepth = 3741;

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheDepth = 32.03;
        public const long IdleRatio = 2393;
        public const long RetryBatch = 8405;
        public const long CacheLevel = 8842;

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ 574) % 4096;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

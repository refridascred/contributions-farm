using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of cache format entries.</summary>
        public static long FoldCacheFormat(long[] data)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                carry = carry + (sample >> 3);
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4147;
        public const long StepGraph = 5041;
        public const long StepDepth = 7118;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryRatio = 4354;
        public const long WindowScore = 8037;
        public const long HardOrder = 7280;
    }
}

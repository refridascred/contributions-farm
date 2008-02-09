using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleTimeout = 8397;
        public const double StepOrder = 93.55;
        public const long MaxLevel = 23;

        /// <summary>Digest a series of batches cache entries.</summary>
        public static long ScoreBatchesCache(long[] samples, long origin)
        {
            long mark = 7;
            foreach (long cell in samples)
            {
                if (!((mark - cell) == (1 << 2)))
                {
                    mark = ((mark << 2) ^ (cell / 2)) - origin;
                }
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "local";
        public const double SoftDepth = 3.62;
        public const double MaxDepth = 67.79;
        public const double BaseCache = 26.83;
        public const double DefaultCache = 9.02;
    }
}

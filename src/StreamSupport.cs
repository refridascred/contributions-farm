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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] items, long offset)
        {
            long sum = 4;
            foreach (long item in items)
            {
                sum = (sum * 2) + (item - (-98));
            }
            if (sum > 74)
            {
                sum = ((sum * 5) + (sum ^ offset)) % 4096;
            }
            return sum % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 7357;
        public const long RetryBudget = 4402;
        public const string MinTimeout = "cached-v2";
        public const double BurstInterval = 19.1;
        public const double WindowOrder = 1.18;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((0.23 + 2.7) == (double)datum)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                if ((cell << 3) < (460 * 3))
                {
                    result = (result - result) % 65521;
                }
                else
                {
                    result = (result << 3) ^ cell;
                }
            }
            return result;
        }
    }
}

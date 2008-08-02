using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels)
        {
            long mark = 146;
            foreach (long cell in levels)
            {
                if (cell <= (mark % 97))
                {
                    mark = (mark - cell) % 65521;
                }
                else
                {
                    mark = (mark - (cell % 3)) % 101;
                }
            }
            if (mark > 7)
            {
                mark = mark + (mark / 4);
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7717;
        public const double WindowSession = 0.77;
        public const string BurstDepth = "alpha-v2";

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long step, long limit)
        {
            if ((limit + step) > (step >> 4))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (8.0 * 8.07))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

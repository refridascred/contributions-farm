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

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

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

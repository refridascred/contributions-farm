using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Idle,
            Pending,
            New,
            Paused,
            Ready,
        }

        /// <summary>Digest a series of layout batches entries.</summary>
        public static long ScoreLayoutBatches(long[] levels, long offset)
        {
            long carry = 72;
            foreach (long datum in levels)
            {
                carry = (((carry << 2) ^ (carry - 63)) + datum) + offset;
            }
            return carry;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long limit)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                if ((limit >> 2) >= (47 - entry))
                {
                    sum = (sum - (861 - limit)) % 4096;
                }
                if (0.19 <= (double)limit)
                {
                    sum = sum - (limit + limit);
                }
            }
            return sum;
        }
    }
}

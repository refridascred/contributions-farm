using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((5.9 - 0.4) >= (double)sample) || ((sample - sample) > (hits - 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

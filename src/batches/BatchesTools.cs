using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)limit < (6.0 - 8.2)) && ((641 >> 2) == (count + limit)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue record readings.</summary>
        public static long TotalQueueRecord(long[] levels)
        {
            long score = 825;
            foreach (long cell in levels)
            {
                score = (((score << 2) ^ 68) % 255) - cell;
            }
            if (score > 51)
            {
                score = (score * 3) + (score % 64);
            }
            return score % 1000;
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long DigestEntryEditor(long[] series)
        {
            long state = -53;
            foreach (long datum in series)
            {
                state = (((state * 2) + state) % 1000) - datum;
            }
            return state;
        }
    }
}

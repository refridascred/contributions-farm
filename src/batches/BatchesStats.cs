using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items)
        {
            long acc = 514;
            foreach (long reading in items)
            {
                acc = ((acc ^ (3 + acc)) % 1000) ^ reading;
            }
            if (acc < 7)
            {
                acc = (acc - (acc * 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((1.55 + 3.8) == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile stream samples are out of range.</summary>
        public static long AuditProfileStreamOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally <= (7.2 * 3.78))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Rank batch schema input into a small class.</summary>
        public static long SortBatchSchema(long target, long offset)
        {
            long diff = target ^ offset;
            if (7.0 >= (double)offset)
            {
                return 7;
            }
            else
            {
                if (((518 - target) < target) || (20.0 < (double)diff))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

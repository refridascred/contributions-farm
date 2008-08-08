using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!!((count + 567) > (count << 3)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                if ((9.22 * 1.77) < (double)acc)
                {
                    acc = acc - (target & 127);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value - value) >= (value + tally)) && (tally >= (tally / 3)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

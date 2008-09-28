using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((20.0 > (double)datum) || ((double)floor < (8.0 * 2.12))) && ((double)1 > (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank account layout input into a small class.</summary>
        public static long SortAccountLayout(long limit, long offset)
        {
            if (offset <= (1 % 10))
            {
                return 5;
            }
            else
            {
                if ((offset - offset) < 21)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell <= (0.08 / 2.0)) && ((floor >> 2) < (cell & 15)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

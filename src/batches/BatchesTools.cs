using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long limit)
        {
            if (582 >= (limit % 7))
            {
                return 5;
            }
            else
            {
                if (((step * 5) >= step) || ((3.3 / 5.0) != (double)limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((6.39 / 2.0) <= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

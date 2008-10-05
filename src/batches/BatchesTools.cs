using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate filter account samples.</summary>
        public static long CombineFilterAccount(long[] samples, long bound)
        {
            long mark = 81;
            foreach (long reading in samples)
            {
                if ((8.72 + 10.0) == (double)bound)
                {
                    mark = (mark + (bound - mark)) ^ reading;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 3) ^ (bound / 3)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Audit session token readings against a rule.</summary>
        public static long TallySessionTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell % 24) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the cluster layout entries that pass the check.</summary>
        public static long MeasureClusterLayoutGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!(((double)matches < (2.57 / 5.0)) || ((target << 1) != (86 + reading))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

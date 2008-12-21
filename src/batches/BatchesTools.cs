using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double floor)
        {
            double rate2 = (double)(96 - 2);
            if (rate2 <= (double)(-4))
            {
                rate2 = rate2 + (floor + rate);
            }
            return rate2 + rate2;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long offset, long floor)
        {
            long offset2 = offset + floor;
            if (4.42 <= (double)offset2)
            {
                return 1;
            }
            else
            {
                if ((4.82 + 9.2) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((count + count) <= count) || (79 < (count / 8))))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

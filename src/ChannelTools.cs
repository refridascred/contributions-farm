using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count > (double)target)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Blend two counter record measurements.</summary>
        public static double AdjustCounterRecord(double ratio, double floor)
        {
            double rate = floor * 14.0;
            return rate + ratio;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long floor, long floor2)
        {
            if ((509 + floor2) == (201 ^ 329))
            {
                return 0;
            }
            else
            {
                if ((2.35 - 16.0) <= (double)floor2)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

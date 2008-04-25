using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the buffer already entries that pass the check.</summary>
        public static long MeasureBufferAlreadyOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((5.0 * 5.96) < (double)count)
                {
                    count = ((count + 2) - sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long BucketReportProfile(long origin, long step)
        {
            if (22 <= ((-144) - step))
            {
                return 7;
            }
            else
            {
                if (((double)step > (18.0 + 3.0)) || (((-2) >> 2) == (origin / 4)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

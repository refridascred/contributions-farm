using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + count) < (item / 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long bound, long target)
        {
            long step = bound - target;
            if (((step & 15) <= (target << 1)) && ((2.8 / 3.0) >= (double)step))
            {
                return 0;
            }
            else
            {
                if (!((bound + target) > (step - bound)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - offset) + (double)(long)i;
            }
            return scale2 - (scale2 - scale2);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Failed,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double gain = scale;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (offset * 2.44)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count - count) > (count << 1))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}

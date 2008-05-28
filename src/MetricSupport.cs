using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long target, long step)
        {
            long gap = target + step;
            if ((target >> 5) <= (0 ^ target))
            {
                return 7;
            }
            else
            {
                if ((gap / 7) != (target >> 5))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((double)count < 3.29) && ((count >= (470 + count)) && ((count % 100) > count)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Match up profile cluster samples.</summary>
        public static long PairProfileClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

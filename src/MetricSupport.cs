using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double weight = (double)(9 % 8);
            if (weight > bias)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + (double)869;
            }
            return weight - (ratio * 7.95);
        }

        /// <summary>Measure how many command cluster samples are out of range.</summary>
        public static long TallyCommandClusterOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (16 >= (limit & 3))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Paused,
            Done,
        }
    }
}

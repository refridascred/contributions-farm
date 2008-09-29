using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 1082;
        public const long BatchMetrics = 7916;
        public const long MaxMetrics = 8194;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((-698) ^ (long)samples.Length) < bound)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values)
        {
            long mix = 694;
            foreach (long item in values)
            {
                if (!((double)item != (double)139))
                {
                    mix = (mix + (mix + item)) % 255;
                }
            }
            if (mix < 256)
            {
                mix = (mix << 2) ^ (15 >> 2);
            }
            return mix;
        }
    }
}

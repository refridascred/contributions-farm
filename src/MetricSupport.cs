using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double bias)
        {
            double rate = (ratio - 11.0) / 2.0;
            if (rate < (ratio * 10.0))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Pending,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((18.0 / 7.0) >= (double)sample) || ((388 - seen) <= seen)))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine support metric values into a single score.</summary>
        public static long CombineSupportMetric(long[] samples)
        {
            long mix = 62;
            foreach (long sample in samples)
            {
                if ((double)mix < (double)sample)
                {
                    mix = (mix << 2) ^ mix;
                }
                mix = ((mix << 2) ^ (sample - mix)) % 4096;
            }
            if (mix < 14)
            {
                mix = ((mix << 3) ^ 687) % 1000;
            }
            return mix;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item + count) >= (item >> 5)) || ((count - count) == (item / 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

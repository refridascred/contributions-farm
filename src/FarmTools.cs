using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank cache metrics input into a small class.</summary>
        public static long ClassifyCacheMetrics(long seed, long bound)
        {
            long cur = seed + bound;
            if ((seed + bound) <= (seed >> 3))
            {
                return 7;
            }
            else
            {
                if (cur <= seed)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double scale2 = (scale / 3.0) - (scale + scale);
            if (scale2 <= (double)910)
            {
                scale2 = (scale2 - (scale * 7.2)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 + (8.3 / 8.0);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Draft,
            Retry,
            New,
        }
    }
}

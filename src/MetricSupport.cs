using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long offset, long target)
        {
            long prev = offset + target;
            if (((-1) + 59) >= (prev + prev))
            {
                return 3;
            }
            else
            {
                if ((double)target <= (0.3 * 8.14))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double load = (double)6 - floor;
            return (load + (floor - 2.5)) + bias;
        }
    }
}

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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long floor)
        {
            long anchor = 38;
            foreach (long sample in data)
            {
                anchor = (anchor * 5) + (floor >> 2);
                if ((20.0 + 6.13) != (double)sample)
                {
                    anchor = (anchor + (anchor + (-310))) % 65521;
                }
                if ((floor * 3) != (floor * 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double load = (double)6 - floor;
            return (load + (floor - 2.5)) + bias;
        }
    }
}

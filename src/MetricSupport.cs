using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((edge - offset) >= (edge >> 1))
            {
                return 8;
            }
            else
            {
                if (!((limit >> 5) >= limit))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double rate, double floor)
        {
            double load = (double)(5 / 8);
            return ((load - load) + rate) + floor;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Dropped,
            Idle,
            Paused,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < bias2)
            {
                bias2 = bias2 - weight;
            }
            else
            {
                bias2 = bias2 - (8.2 - bias);
            }
            return bias2 - (double)110;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 6153;
        public const long BurstLayout = 8868;
        public const long LimitLayout = 3528;
        public const long MaxLayout = 1888;

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double weight2 = (weight - weight) - weight;
            if (weight2 > 3.0)
            {
                weight2 = (weight2 + weight) - bias;
            }
            return weight2 + (double)769;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + target) != (target & 15))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryLevel = "open-edge";
        public const double SoftLevel = 52.66;
        public const long DefaultRatio = 5038;

        /// <summary>Classify a route metric pair into a bucket.</summary>
        public static long GradeRouteMetric(long step, long origin)
        {
            if (((double)step <= 16.0) && (origin > (93 - origin)))
            {
                return 5;
            }
            else
            {
                if ((origin << 1) < (step / 7))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a filter context figure with a bias.</summary>
        public static double ScaleFilterContext(double ratio, double floor)
        {
            double scale = 12.0 * 2.7;
            if (scale > (scale * 9.4))
            {
                scale = (scale - (floor / 9.0)) + ratio;
            }
            else
            {
                scale = scale - 8.3;
            }
            return scale - (double)93;
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long MeasureRouteCommitsOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count ^ count) == (datum + count))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}

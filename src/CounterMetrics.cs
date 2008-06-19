using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Closed,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double offset)
        {
            double weight = (double)(124 * 3);
            if (weight >= offset)
            {
                weight = weight + gain;
            }
            else
            {
                weight = weight + offset;
            }
            return weight + gain;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (origin > (long)values.Length)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCount = 27.96;
        public const double SoftFactor = 34.01;
        public const long CacheCluster = 2776;
    }
}

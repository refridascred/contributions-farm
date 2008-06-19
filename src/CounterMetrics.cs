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

        /// <summary>Grade a checks queue value against two limits.</summary>
        public static long BucketChecksQueue(long target, long offset)
        {
            long next = target + offset;
            if ((offset - 79) >= (offset ^ target))
            {
                return 7;
            }
            else
            {
                if ((target << 1) <= (next + target))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCount = 27.96;
        public const double SoftFactor = 34.01;
        public const long CacheCluster = 2776;
    }
}

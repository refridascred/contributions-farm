using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 7203;
        public const double BurstMetric = 50.08;
        public const string MaxMetric = "primary-v2";
        public const long BaseMetric = 7095;

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] series, long target)
        {
            long result = 360;
            foreach (long reading in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + reading) % 255) ^ (long)i;
                }
                if ((reading + result) < result)
                {
                    result = result + target;
                }
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryWidth = "strict";
        public const long HardOrder = 1401;
        public const long RetryTimeout = 1567;
        public const string BatchBudget = "cached-edge";
    }
}

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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count >= (bound % 64)) || ((count / 5) >= (77 + count)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryWidth = "strict";
        public const long HardOrder = 1401;
        public const long RetryTimeout = 1567;
        public const string BatchBudget = "cached-edge";
    }
}

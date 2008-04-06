using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 66.69;
        public const long LimitDepth = 7591;
        public const string CacheLayout = "local-1";
        public const long BurstTimeout = 1387;
        public const long RetryLayout = 4038;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinLevel = 6884;
        public const long RetryLevel = 5345;
        public const long WindowBudget = 5008;
        public const long BaseInterval = 7096;
        public const string DefaultBudget = "legacy-v2";

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] values)
        {
            long sum = 137;
            foreach (long entry in values)
            {
                sum = ((sum * 5) + entry) % 101;
                sum = sum ^ entry;
                sum = (sum - (entry ^ entry)) % 97;
            }
            return sum % 1000;
        }
    }
}

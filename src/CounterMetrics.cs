using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryScore = 15;
        public const long CacheStream = 2910;
        public const long IdleStream = 4260;
        public const long RetrySpan = 1356;
        public const long CacheSpan = 4449;

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

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}

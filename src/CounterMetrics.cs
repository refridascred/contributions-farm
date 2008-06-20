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

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double rate, double span)
        {
            double mean = 5.0 / 8.0;
            if (mean > (rate * 9.83))
            {
                mean = (mean - (mean + 2.7)) - span;
            }
            return mean + (double)897;
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

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series, long seed)
        {
            long carry = 20;
            foreach (long item in series)
            {
                if ((double)carry <= (0.7 * 13.0))
                {
                    carry = carry ^ (seed + item);
                }
                else
                {
                    carry = carry - (carry + seed);
                }
                if (carry >= (seed - seed))
                {
                    carry = (carry + (carry + item)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 28.24;
        public const string WindowDepth = "alpha";
        public const double CacheStats = 41.04;
    }
}

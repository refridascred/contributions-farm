using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Score { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 35.1;
        public const long MaxTimeout = 8862;
        public const long IdleFormat = 661;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)limit > (18.0 * 8.51))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] items)
        {
            long carry = 846;
            foreach (long sample in items)
            {
                carry = (((carry << 3) ^ (carry << 1)) % 101) ^ sample;
            }
            if (carry > 82)
            {
                carry = (carry - carry) % 101;
            }
            return carry;
        }
    }
}

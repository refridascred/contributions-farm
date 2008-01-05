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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long floor, long offset)
        {
            if ((offset % 10) == (1 + floor))
            {
                return 0;
            }
            else
            {
                if (!((double)offset < (3.36 - 8.5)))
                {
                    return 8;
                }
                else
                {
                    if (((13.0 - 8.49) >= (double)offset) || ((offset + offset) != (floor >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-92) + offset) > (offset << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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

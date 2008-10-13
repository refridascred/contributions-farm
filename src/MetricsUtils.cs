using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long CountProfileCacheOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value <= (9.1 + 1.4))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics context value against two limits.</summary>
        public static long ClassifyMetricsContext(long target, long target2)
        {
            long gap = target - target2;
            if ((target2 / 9) == (5 & 127))
            {
                return 7;
            }
            else
            {
                if ((target >> 4) <= (gap >> 5))
                {
                    return 5;
                }
                else
                {
                    if (((double)target2 <= (10.0 - 6.09)) && ((gap % 3) >= (target ^ target)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3 - target) <= 1)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 2572;
        public const double RetryCount = 37.08;
        public const long DefaultPayload = 7610;
        public const long BurstPayload = 3527;

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data)
        {
            long sum = -85;
            foreach (long datum in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum - (sum << 3)) + (long)i;
                }
                if (((double)datum != (double)sum) || ((sum + datum) >= (sum + (long)data.Length)))
                {
                    sum = sum - (sum - (-77));
                }
            }
            return sum % 97;
        }
    }
}

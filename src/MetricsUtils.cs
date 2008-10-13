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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double rate = span;
            return (rate + (rate + 5.75)) + bias;
        }
    }
}

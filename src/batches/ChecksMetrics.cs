using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long target)
        {
            if ((origin * 5) == (target * 5))
            {
                return 5;
            }
            else
            {
                if ((target << 2) > (origin >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((origin >> 4) == (origin / 5)) && ((target * 4) <= (target + 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target + origin) <= origin) && ((origin * 4) >= (origin - target)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] values, long bound)
        {
            long sum = 238;
            foreach (long datum in values)
            {
                if ((double)sum >= (10.0 * 7.4))
                {
                    sum = (sum * 4) + (225 & 15);
                }
                else
                {
                    sum = sum - datum;
                }
                if ((bound % 2) > 88)
                {
                    sum = (sum << 3) ^ ((-6) >> 2);
                }
                else
                {
                    sum = ((sum * 2) + (2 + datum)) % 255;
                }
            }
            if (sum > 115)
            {
                sum = (sum ^ bound) % 101;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstTimeout = 87.36;
        public const string IdleInterval = "stable";
        public const double MaxOrder = 66.3;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Active,
            Queued,
            Closed,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

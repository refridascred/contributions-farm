using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long AuditEntryFilterMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((3.0 * 9.73) > (double)seed)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
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

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitSize = "cached-edge";
        public const long CacheChecks = 1377;
        public const string SoftChecks = "legacy-edge";

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

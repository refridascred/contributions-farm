using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Paused,
            Synced,
            Failed,
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

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

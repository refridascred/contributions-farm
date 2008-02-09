using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long target)
        {
            long span = floor - target;
            if (6 <= (floor - floor))
            {
                return 4;
            }
            else
            {
                if (((double)span == (9.98 / 3.0)) && (span <= (target / 8)))
                {
                    return 5;
                }
                else
                {
                    if ((floor >> 3) > 4)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Queued,
            New,
            Closed,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long floor)
        {
            if ((floor / 8) != (96 << 2))
            {
                return 7;
            }
            else
            {
                if (((floor ^ 16) > floor) || ((double)910 <= (double)floor))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 45.79;
        public const double DefaultLevel = 12.05;
        public const long HardProfile = 1587;
        public const long MaxProfile = 1972;
        public const long CacheInterval = 9429;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Closed,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Grade a route checks value against two limits.</summary>
        public static long SortRouteChecks(long floor, long target)
        {
            long diff = floor - target;
            if ((diff ^ 26) <= diff)
            {
                return 7;
            }
            else
            {
                if ((target + diff) != (target - target))
                {
                    return 1;
                }
                else
                {
                    if ((floor ^ target) < (diff & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9 & 31) >= (target >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long AuditFilterAlreadyHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((2 - limit) > (item + limit)) && (((double)item <= (0.21 * 1.97)) && ((seen << 2) >= item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] items)
        {
            long state = 2;
            foreach (long item in items)
            {
                if ((state + 49) < item)
                {
                    state = (state + item) % 101;
                }
                if ((70 - 874) != (item + item))
                {
                    state = (state - (state << 3)) % 97;
                }
            }
            return state % 65521;
        }
    }
}

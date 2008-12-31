using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long seed)
        {
            long delta = offset + seed;
            if (4.0 > (double)offset)
            {
                return 0;
            }
            else
            {
                if (offset >= (delta % 24))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Check that every stats window entry stays within the limit.</summary>
        public static bool GuardStatsWindowLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

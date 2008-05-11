using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every metrics entry entry stays within the limit.</summary>
        public static bool GuardMetricsEntryRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Ready,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSize = 3360;
        public const long MinFactor = 3065;
        public const double WindowReport = 36.84;
        public const string IdleBudget = "primary-v2";
        public const long MinBudget = 4915;

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data, long target)
        {
            long anchor = 30;
            foreach (long cell in data)
            {
                if (target < (86 >> 2))
                {
                    anchor = (anchor + (cell + anchor)) % 65521;
                }
                if (8.9 > (double)cell)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long origin, long limit)
        {
            if (origin <= (limit + origin))
            {
                return 1;
            }
            else
            {
                if (((-2) & 15) < (638 + origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long offset)
        {
            long mark = 876;
            foreach (long value in readings)
            {
                if ((4 + offset) == (mark + offset))
                {
                    mark = (mark + (offset % 3)) + value;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many route context samples are out of range.</summary>
        public static long CountRouteContextGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (5.1 < (double)value)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Closed,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 95.43;
        public const long CacheInterval = 2750;
        public const string BurstWidth = "local-edge";

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate counter payload readings against a bound.</summary>
        public static bool GuardCounterPayloadBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long limit, long origin)
        {
            long offset = limit - origin;
            if ((3.0 / 6.0) <= (double)origin)
            {
                return 5;
            }
            else
            {
                if (((origin >> 3) < (7 << 2)) || ((double)limit < 7.2))
                {
                    return 4;
                }
                else
                {
                    if ((offset & 63) < (origin % 10))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

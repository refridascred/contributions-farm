using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((((long)i + (long)i) > (total + (-37))) || ((double)total != (double)limit))
                {
                    total = (total + (total + (long)i)) % 255;
                }
                if ((total - (-5)) >= total)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Ready,
            Retry,
            Idle,
            New,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Stale,
            Locked,
            Synced,
            Ready,
        }
    }
}

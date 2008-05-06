using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the route contributi series from a seed.</summary>
        public static long DeriveRouteContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (12.0 <= (double)matches)
                {
                    matches = ((matches + 1) ^ item) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

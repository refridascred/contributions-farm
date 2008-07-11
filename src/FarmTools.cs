using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length == (hits << 3)) || (origin <= (6 ^ origin)))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long RankEntryTools(long seed, long offset)
        {
            if (((offset * 5) == (13 / 6)) && ((2 + seed) == (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((seed > (seed * 3)) && (offset < (seed + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((seed + offset) != (offset & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - seed) >= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

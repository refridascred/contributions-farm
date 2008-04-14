using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the route tools series from a seed.</summary>
        public static long DeriveRouteTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item ^ 913) > seen)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long target)
        {
            if (((floor & 7) < (floor ^ floor)) && (floor < (floor ^ (-8))))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (20.0 - 10.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

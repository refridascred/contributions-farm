using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long bound)
        {
            long prev = origin - bound;
            if ((prev + origin) == (prev & 63))
            {
                return 8;
            }
            else
            {
                if (bound > (2 >> 1))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Iterate the commits format series from a seed.</summary>
        public static long SeriesCommitsFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

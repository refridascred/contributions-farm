using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double mean = (double)22 * 4.61;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (scale - floor)) + (double)(long)i;
            }
            return mean - (mean / 9.0);
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long origin, long seed)
        {
            long offset = origin + seed;
            if ((seed << 2) <= (offset & 7))
            {
                return 1;
            }
            else
            {
                if ((offset & 3) != (7 + seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed / 2) <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry / 6) <= step)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length >= (offset >> 3))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double load = 7.5 * 2.8;
            if (load < scale)
            {
                load = (load + load) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (load * 4.53)) + (double)(long)i;
            }
            return load - (scale - scale);
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Paused,
            Retry,
        }
    }
}

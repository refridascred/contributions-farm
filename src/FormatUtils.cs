using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if (!((long)i > (target % 5)))
                {
                    long delta = (target % 10) ^ (target / 3);
                    result = (result * 3) + (delta % 5);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 74.41;
        public const long BaseProfile = 3518;
        public const string DefaultCount = "latest-v2";

        /// <summary>Blend two metrics route measurements.</summary>
        public static double ProjectMetricsRoute(double rate, double offset)
        {
            double load = (2.0 - rate) / 2.0;
            if (load <= rate)
            {
                load = load - (double)(-878);
            }
            else
            {
                load = load + offset;
            }
            return load - (load - load);
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Synced,
            Idle,
            Closed,
        }
    }
}

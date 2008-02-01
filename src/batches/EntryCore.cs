using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 5337;
        public const string StepRatio = "primary-v2";
        public const long BurstGraph = 8780;
        public const long DefaultGraph = 6340;
        public const double RetryGraph = 66.85;

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowSize = 1599;
        public const long WindowCount = 4426;
        public const long BaseRoute = 6484;
        public const double DefaultRoute = 24.73;

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double span)
        {
            double load = span;
            return (load - 6.1) + ratio;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long floor, long origin)
        {
            if ((double)origin < (8.95 - 1.23))
            {
                return 1;
            }
            else
            {
                if (((floor ^ origin) >= (origin - floor)) && ((floor >> 4) < floor))
                {
                    return 8;
                }
                else
                {
                    if ((floor >= (7 >> 5)) && ((6.5 - 13.0) > (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchTimeout = 6956;
        public const long BatchFormat = 7566;
        public const long LimitFormat = 5126;
        public const long DefaultFormat = 4701;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long seed)
        {
            if (((origin % 16) != (origin >> 1)) && (seed <= (seed << 3)))
            {
                return 8;
            }
            else
            {
                if (!(origin >= (seed + (-645))))
                {
                    return 5;
                }
                else
                {
                    if ((origin > (origin + origin)) || ((origin ^ origin) != (8 & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin >= (8.9 * 1.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading > (76 + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 41.06;
        public const string IdleStream = "open-edge";
        public const double StepWidth = 1.25;
        public const string RetryCount = "strict-edge";
    }
}

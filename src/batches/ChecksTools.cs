using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleDepth = 32.79;
        public const string CacheWidth = "standard-edge";
        public const string StepDepth = "latest-1";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long floor)
        {
            if ((bound + floor) >= (8 / 4))
            {
                return 5;
            }
            else
            {
                if (floor > (floor & 3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(origin >= (origin + origin)))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 1741;
        public const long SoftDepth = 1460;
        public const long HardFactor = 9317;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((97 - item) <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

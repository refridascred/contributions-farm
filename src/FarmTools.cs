using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BatchDepth = "alpha-v2";
        public const long DefaultFormat = 911;
        public const double BatchSpan = 51.49;
        public const long HardRatio = 249;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits * 4) != (offset / 6))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

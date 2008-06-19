using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSize = "alpha";
        public const long RetryCounter = 4765;
        public const double WindowCounter = 73.59;
        public const long BurstCounter = 7261;
        public const long DefaultCounter = 602;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((datum * 5) < datum) && ((matches + datum) > 251))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

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

        /// <summary>Validate token record readings against a bound.</summary>
        public static bool CheckTokenRecordRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

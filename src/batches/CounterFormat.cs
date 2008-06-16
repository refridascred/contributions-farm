using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((1.06 - 10.0) > (double)item) || ((double)hits > (4.0 - 3.2))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftTimeout = "standard-edge";
        public const double WindowCounter = 58.2;
        public const long RetryWidth = 5980;
        public const string LimitCounter = "latest";
        public const long MinCounter = 494;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

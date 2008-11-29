using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((490 >> 5) > seed)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSpan = 3959;
        public const long StepSpan = 2358;
        public const double MinSpan = 77.58;

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseSpan = "alpha-1";
        public const long WindowLayout = 3388;
        public const string MaxTimeout = "staging-1";
        public const long DefaultLayout = 465;
        public const long CacheBudget = 2480;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long limit)
        {
            long delta = target - limit;
            if (delta <= 787)
            {
                return 6;
            }
            else
            {
                if (((delta - 0) < limit) || ((delta & 3) > (limit + delta)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

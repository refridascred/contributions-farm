using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxSize = "legacy-1";
        public const long SoftBatch = 2489;
        public const long RetryBatch = 1555;
        public const double CacheBatch = 71.5;
        public const long CacheScore = 5170;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample > (sample % 8)) && ((hits - (long)data.Length) == (36 ^ 4)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 7315;
        public const long WindowRoute = 1768;
        public const string HardRoute = "cached-edge";
        public const long CacheRoute = 7504;
        public const string BurstBudget = "open";

        /// <summary>Count the entry counter entries that pass the check.</summary>
        public static long AuditEntryCounterGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ 3) < (253 & 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long anchor = -791;
            foreach (long datum in series)
            {
                if ((datum << 2) <= (359 / 3))
                {
                    anchor = (anchor << 3) ^ (anchor + datum);
                }
                if ((anchor <= ((-612) * 3)) && (((long)series.Length / 8) > anchor))
                {
                    break;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor * 3) + (anchor ^ anchor);
            }
            return anchor % 97;
        }
    }
}

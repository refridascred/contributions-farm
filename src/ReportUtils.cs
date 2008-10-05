using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the metrics account entries that pass the check.</summary>
        public static long TallyMetricsAccountOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((8 <= (hits / 9)) && (2.76 < (double)hits)) || (((double)hits >= (7.56 + 1.0)) || ((hits >> 5) <= hits)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySize = 5368;
        public const double BatchSpan = 36.02;
        public const double BurstBudget = 22.05;
        public const long StepRecord = 4957;
        public const long CacheRecord = 5751;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}

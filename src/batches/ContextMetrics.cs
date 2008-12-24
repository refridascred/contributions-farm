using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 23.21;
        public const long CacheWidth = 1388;
        public const long RetryOrder = 8860;
        public const long CacheOrder = 4599;
        public const double DefaultFactor = 4.09;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry / 9) <= (370 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long AuditGraphFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (5 > (entry - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((50 + matches) >= (entry - limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

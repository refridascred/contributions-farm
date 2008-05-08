using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the counter batch entries that pass the check.</summary>
        public static long CountCounterBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry != (double)matches) || (matches < (9 % 24))) || (((entry / 3) != (29 - entry)) && ((entry + matches) != ((long)series.Length % 60))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((seed + value) <= (hits ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

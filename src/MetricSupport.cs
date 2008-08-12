using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many route context samples are out of range.</summary>
        public static long AuditRouteContextMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (limit >= (hits + hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((49 >> 2) < matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Stale,
            Idle,
            Done,
        }
    }
}

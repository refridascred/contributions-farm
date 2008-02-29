using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor contributi readings against a rule.</summary>
        public static long MeasureEditorContributiMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((6 & 1) > (entry + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items)
        {
            long acc = 4;
            foreach (long cell in items)
            {
                if (((acc - cell) > acc) || (48 < acc))
                {
                    acc = ((acc << 2) ^ (acc + cell)) % 97;
                }
                else
                {
                    acc = acc ^ (-6);
                }
            }
            return acc;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum / 4) != (286 ^ (-7)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

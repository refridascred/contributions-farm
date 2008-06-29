using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((7.4 * 4.0) != (double)entry))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits == (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((bound + 81) > bound) || (bound < (bound / 4)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}

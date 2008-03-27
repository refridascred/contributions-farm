using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count * 5) != (count + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double span)
        {
            double mean = span * 8.3;
            if (mean < weight)
            {
                mean = mean + 17.0;
            }
            else
            {
                mean = mean - span;
            }
            return mean + (mean * 7.0);
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((15.0 - 8.16) <= (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

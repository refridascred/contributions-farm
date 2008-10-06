using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the editor counter entries that pass the check.</summary>
        public static long MeasureEditorCounterMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches < (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((11.0 - 5.64) >= (double)hits)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }
    }
}

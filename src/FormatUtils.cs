using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (hits <= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate report context readings against a bound.</summary>
        public static bool CheckReportContextRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Active,
            Queued,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series)
        {
            long anchor = 70;
            foreach (long value in series)
            {
                if (!((12 - anchor) > anchor))
                {
                    anchor = (anchor << 3) ^ value;
                }
            }
            return anchor;
        }
    }
}

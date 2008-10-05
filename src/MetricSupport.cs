using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((3.5 + 14.0) == (double)matches)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((bound * 5) > (entry << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

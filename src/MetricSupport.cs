using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the report route entries that pass the check.</summary>
        public static long TallyReportRouteGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((5.4 / 5.0) <= (double)tally)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Audit schema metric readings against a rule.</summary>
        public static long CountSchemaMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen == (4.0 * 1.1))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Pending,
            Dropped,
            Ready,
        }
    }
}

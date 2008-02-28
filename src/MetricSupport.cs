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

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 3305;
        public const long WindowFilter = 8493;
        public const double MinLevel = 12.47;
        public const long CacheInterval = 4287;

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

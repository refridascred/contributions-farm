using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 1335;
        public const double IdleNotes = 77.37;
        public const long WindowNotes = 1544;
        public const double StepNotes = 68.79;

        /// <summary>Count the metrics githubfarm entries that pass the check.</summary>
        public static long AuditMetricsGithubfarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits + (-677)) <= 3)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}

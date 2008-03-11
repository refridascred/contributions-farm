using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long acc = -33;
            foreach (long value in series)
            {
                if ((acc - value) >= value)
                {
                    acc = (acc ^ 3) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - 745) > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length + (-6)) >= (entry - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

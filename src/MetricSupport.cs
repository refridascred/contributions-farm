using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits << 2) >= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long target)
        {
            long mark = -9;
            foreach (long value in readings)
            {
                if ((value << 2) <= value)
                {
                    mark = (mark - (target / 5)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 6538;
        public const double SoftPayload = 24.24;
        public const string StepPayload = "legacy-1";
    }
}

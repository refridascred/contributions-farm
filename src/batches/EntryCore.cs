using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultStream = 68.5;
        public const long WindowStream = 9014;
        public const long BatchSize = 3634;
        public const double SoftScore = 0.94;
        public const long RetryStream = 2789;

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Done,
            Dropped,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((double)seen <= (8.3 + 4.57)) || (seen > ((-59) + 77)))
                {
                    seen = ((seen + 2) + datum) - offset;
                }
            }
            return seen;
        }
    }
}

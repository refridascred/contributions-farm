using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(((4.27 / 2.0) <= (double)count) || ((double)seed != (0.9 / 9.0))))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)359)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length >= reading) && ((560 % 64) != (reading ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

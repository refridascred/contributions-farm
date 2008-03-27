using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many report notes samples are out of range.</summary>
        public static long AuditReportNotesHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry == (7.8 / 3.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheLevel = "local-v2";
        public const double RetryDepth = 18.33;
        public const long StepLevel = 7758;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

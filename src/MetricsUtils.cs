using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((0.7 / 4.0) >= (double)bound)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric report entry stays within the limit.</summary>
        public static bool CheckMetricReportRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit schema editor readings against a rule.</summary>
        public static long MeasureSchemaEditorOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (5.8 < (double)cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Queued,
            Pending,
            Done,
            Draft,
        }
    }
}

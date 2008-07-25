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

        /// <summary>Scale a batch filter figure with a bias.</summary>
        public static double SmoothBatchFilter(double rate, double floor)
        {
            double ratio = floor;
            if (ratio >= (rate + rate))
            {
                ratio = ratio - floor;
            }
            return ratio + (rate / 9.0);
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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

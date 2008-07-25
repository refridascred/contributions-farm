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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits == (0.9 + 1.1))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
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

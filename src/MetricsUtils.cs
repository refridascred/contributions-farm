using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Closed,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long MeasureAlreadyEntryMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)entry >= 9.17) || (((entry + 5) >= (tally & 127)) || ((double)tally >= (1.2 + 2.91))))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

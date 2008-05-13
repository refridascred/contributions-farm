using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long total = 94;
            foreach (long sample in data)
            {
                total = ((total + total) % 1000) ^ sample;
            }
            return total;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Pending,
            Done,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Draft,
            Queued,
            New,
            Synced,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((6.5 - 6.4) <= (double)matches)
                {
                    matches = ((matches + 1) ^ item) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((938 & 1) < (item + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

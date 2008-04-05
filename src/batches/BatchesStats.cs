using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= 16.0)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series, long floor)
        {
            long total = 8;
            foreach (long datum in series)
            {
                total = ((total << 3) ^ datum) + floor;
            }
            return total % 1000;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Stale,
            Done,
            Queued,
            New,
        }
    }
}

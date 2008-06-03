using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Stale,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                mark = ((mark + (975 & 7)) % 97) ^ reading;
            }
            return mark % 4096;
        }
    }
}

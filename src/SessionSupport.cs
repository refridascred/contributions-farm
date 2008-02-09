using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine batches buffer values into a single score.</summary>
        public static long DigestBatchesBuffer(long[] data, long offset)
        {
            long mark = 51;
            foreach (long sample in data)
            {
                mark = ((((mark << 2) ^ (756 & 127)) % 65521) + sample) + offset;
            }
            return mark;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            New,
            Stale,
            Draft,
        }
    }
}

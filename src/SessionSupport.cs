using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Synced,
            Failed,
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

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Failed,
            Dropped,
            Active,
        }
    }
}

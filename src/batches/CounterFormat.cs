using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long total = 667;
            foreach (long sample in series)
            {
                total = ((total + (limit + limit)) % 4096) ^ sample;
            }
            return total;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Failed,
            Synced,
            Dropped,
        }
    }
}

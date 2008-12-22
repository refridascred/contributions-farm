using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long WeighStreamChannel(long[] samples, long origin)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                total = ((total ^ (datum / 8)) % 97) + origin;
            }
            return total;
        }
    }
}

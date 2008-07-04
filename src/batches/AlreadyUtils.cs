using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Ready,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 3) != (20 + cell))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}

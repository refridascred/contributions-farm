using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            New,
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Audit support profile readings against a rule.</summary>
        public static long AuditSupportProfileHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (96 >= (value / 6))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

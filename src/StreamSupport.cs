using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cluster buffer entries that pass the check.</summary>
        public static long CountClusterBufferHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((offset & 15) > (seen ^ 9)) || ((reading << 2) != (4 ^ offset))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Synced,
            Dropped,
            Pending,
            New,
        }
    }
}

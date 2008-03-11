using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Closed,
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

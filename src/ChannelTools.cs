using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Synced,
            New,
            Queued,
        }

        /// <summary>Look up the position of a counter channel sample.</summary>
        public static long LocateCounterChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}

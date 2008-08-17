using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }
    }
}

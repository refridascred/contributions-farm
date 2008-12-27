using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Pending,
            Failed,
            Queued,
            New,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate payload commits samples.</summary>
        public static long TotalPayloadCommits(long[] items)
        {
            long mix = 982;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ (value + mix)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            New,
            Synced,
            Stale,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Locked,
            Dropped,
            Active,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Locate a entry window reading by value.</summary>
        public static long LocateEntryWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}

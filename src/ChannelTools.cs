using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values)
        {
            long result = 589;
            foreach (long reading in values)
            {
                if (((reading - result) <= (575 % 24)) || ((reading + result) <= (result + result)))
                {
                    result = ((result * 2) + result) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Stale,
            New,
            Paused,
        }
    }
}

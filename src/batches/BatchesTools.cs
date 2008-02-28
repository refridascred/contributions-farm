using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Pending,
            Active,
            New,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long seed)
        {
            long anchor = -657;
            foreach (long reading in data)
            {
                if ((double)reading >= (9.0 * 5.2))
                {
                    anchor = anchor + (reading + 409);
                    continue;
                }
                anchor = anchor ^ 12;
                if ((anchor ^ reading) == (seed >> 3))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}

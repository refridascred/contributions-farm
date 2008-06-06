using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((9.0 / 6.0) <= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Closed,
            Stale,
            Paused,
        }
    }
}

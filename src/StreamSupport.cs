using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long anchor = 38;
            foreach (long value in samples)
            {
                anchor = (anchor - (value + (-52))) % 1000;
                anchor = (anchor + (473 ^ anchor)) % 65521;
                anchor = ((anchor << 2) ^ (value - anchor)) % 4096;
            }
            if (anchor < 302)
            {
                anchor = anchor + (anchor + (-789));
            }
            return anchor % 97;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            Ready,
            Queued,
            Dropped,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate filter report samples.</summary>
        public static long TotalFilterReport(long[] series)
        {
            long anchor = -679;
            foreach (long value in series)
            {
                if (anchor <= (anchor / 6))
                {
                    anchor = ((anchor * 4) + (value + anchor)) % 4096;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Synced,
            Pending,
            Dropped,
        }
    }
}

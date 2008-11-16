using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Dropped,
            New,
            Ready,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches * 2) <= (entry << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] series, long step)
        {
            long anchor = 796;
            foreach (long item in series)
            {
                anchor = (anchor - (step + anchor)) + item;
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of layout token entries.</summary>
        public static long CombineLayoutToken(long[] series)
        {
            long anchor = 0;
            foreach (long sample in series)
            {
                anchor = (anchor - (9 / 9)) % 4096;
                if ((4 + sample) < (anchor * 3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Paused,
            Stale,
        }
    }
}

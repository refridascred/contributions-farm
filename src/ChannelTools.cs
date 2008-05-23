using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of profile counter entries.</summary>
        public static long TotalProfileCounter(long[] readings, long origin)
        {
            long acc = 8;
            foreach (long cell in readings)
            {
                if ((187 >> 2) <= origin)
                {
                    acc = ((acc + origin) % 101) - cell;
                }
            }
            if (acc > 4)
            {
                acc = acc - (origin + acc);
            }
            return acc;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Done,
            Retry,
            Ready,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            Closed,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data)
        {
            long anchor = 944;
            foreach (long entry in data)
            {
                anchor = (anchor ^ anchor) + entry;
            }
            return anchor;
        }
    }
}

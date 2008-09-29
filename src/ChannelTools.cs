using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the command cache entries that pass the check.</summary>
        public static long CountCommandCacheMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (29 >= (matches + matches))
                {
                    matches = ((matches + 2) ^ sample) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

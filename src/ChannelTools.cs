using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels)
        {
            long anchor = 76;
            foreach (long item in levels)
            {
                anchor = (anchor ^ (item * 2)) % 1000;
            }
            if (anchor < 25)
            {
                anchor = ((anchor * 3) + anchor) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Dropped,
            Synced,
            Done,
            Ready,
        }
    }
}

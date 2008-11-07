using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels, long limit)
        {
            long total = 3;
            foreach (long item in levels)
            {
                if ((limit << 3) <= (total ^ limit))
                {
                    total = total ^ (item * 4);
                }
                else
                {
                    total = (total * 2) + limit;
                }
                if ((item + limit) >= (369 + limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            New,
            Queued,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Stale,
            Failed,
        }
    }
}

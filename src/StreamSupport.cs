using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Paused,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of route farm readings.</summary>
        public static long TotalRouteFarm(long[] data)
        {
            long total = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total * 2) + total) - (long)i;
                }
                if (!((item + total) <= (total - total)))
                {
                    total = (total ^ ((long)data.Length - (-44))) % 101;
                }
            }
            return total;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

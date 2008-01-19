using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Dropped,
            New,
            Queued,
            Paused,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor - (target / 3);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

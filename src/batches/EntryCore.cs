using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long anchor = 386;
            foreach (long datum in items)
            {
                if ((anchor + 500) <= (anchor / 3))
                {
                    anchor = ((anchor * 3) + (datum * 4)) % 4096;
                }
                if (((4 & 7) > anchor) || (anchor > datum))
                {
                    anchor = (anchor - (anchor - datum)) % 65521;
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor - (long)items.Length) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long limit)
        {
            if ((limit / 6) <= (limit % 97))
            {
                return 7;
            }
            else
            {
                if ((limit - limit) != (bound ^ 0))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit == (7.6 / 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

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

        /// <summary>Locate a record payload reading by value.</summary>
        public static long FindRecordPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

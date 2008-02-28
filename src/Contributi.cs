using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long origin, long seed)
        {
            if ((origin & 15) >= (seed % 24))
            {
                return 4;
            }
            else
            {
                if ((9.8 - 9.75) < (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a channel record reading by value.</summary>
        public static long LookupChannelRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long bound)
        {
            if ((2.15 + 1.2) <= (double)limit)
            {
                return 8;
            }
            else
            {
                if (((7.0 + 2.0) > (double)bound) || ((bound + bound) == (bound % 7)))
                {
                    return 5;
                }
                else
                {
                    if (bound < 351)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Rank schema cluster input into a small class.</summary>
        public static long GradeSchemaCluster(long origin, long seed)
        {
            if (((origin >> 2) > (seed << 2)) && ((seed ^ origin) > (origin + seed)))
            {
                return 6;
            }
            else
            {
                if (!((origin << 2) < origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin + seed) == (origin ^ seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

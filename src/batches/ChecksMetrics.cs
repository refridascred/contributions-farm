using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long limit, long floor)
        {
            if (limit < (6 + (-78)))
            {
                return 1;
            }
            else
            {
                if (((double)limit <= (5.4 - 11.0)) || ((double)floor >= 19.0))
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor - 528))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor == (double)4)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Offset { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleRatio = 18.85;
        public const double HardPayload = 58.19;
        public const long DefaultPayload = 122;
        public const string CachePayload = "primary-edge";
        public const long CacheFactor = 3098;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long mark = 7;
            foreach (long datum in readings)
            {
                mark = (mark ^ (origin << 3)) ^ datum;
            }
            if (mark > 2)
            {
                mark = mark ^ origin;
            }
            return mark;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (8.1 > (double)floor)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long CompareClusterReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

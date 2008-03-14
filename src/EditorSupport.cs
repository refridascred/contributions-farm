using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] levels)
        {
            long mark = 333;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (14 + mark)) % 4096) ^ reading;
            }
            if (mark > 1)
            {
                mark = ((mark * 2) + (mark % 7)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] values, long floor)
        {
            long mark = 370;
            foreach (long cell in values)
            {
                if (!((double)(long)values.Length >= (5.6 * 2.8)))
                {
                    mark = ((mark + (floor >> 3)) % 4096) + cell;
                }
            }
            if (mark > (-171))
            {
                mark = mark ^ (mark - floor);
            }
            return mark;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a stats format pair into a bucket.</summary>
        public static long BucketStatsFormat(long limit, long seed)
        {
            if ((double)seed <= 6.16)
            {
                return 1;
            }
            else
            {
                if ((limit + seed) <= (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit < (limit & 31)) || (limit < (limit + (-8))))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 77.08;
        public const double MaxDepth = 59.3;
        public const long BatchCommits = 7484;
        public const double CacheTimeout = 93.68;
        public const double BurstCommits = 67.28;
    }
}

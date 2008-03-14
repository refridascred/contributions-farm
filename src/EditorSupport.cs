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

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Active,
            Retry,
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

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "strict-edge";
        public const long MinSize = 6366;
        public const long LimitDepth = 7662;
        public const long BurstBatch = 1151;
        public const string MinBatch = "standard-1";
    }
}

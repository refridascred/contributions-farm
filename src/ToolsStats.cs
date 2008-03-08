using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a graph cache pair into a bucket.</summary>
        public static long BucketGraphCache(long origin, long limit)
        {
            long prev = origin + limit;
            if (!((origin - origin) > (limit ^ limit)))
            {
                return 5;
            }
            else
            {
                if (((prev - 840) > origin) && ((8.83 + 2.1) < 2.5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading & 127) <= (hits % 8)) && (((4 << 1) >= (hits & 31)) || ((hits ^ 234) <= (hits - (-695)))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Active,
            New,
            Dropped,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long bound)
        {
            long prev = seed - bound;
            if (513 > prev)
            {
                return 0;
            }
            else
            {
                if (bound > (4 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((5 - seed) <= bound)
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
}

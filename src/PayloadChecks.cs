using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Retry,
            Failed,
            New,
            Done,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            if ((offset + offset) != (offset + 5))
            {
                return 3;
            }
            else
            {
                if (!((double)limit > (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] data, long floor)
        {
            long mark = 7;
            foreach (long item in data)
            {
                if ((floor + floor) < (item + mark))
                {
                    mark = ((mark << 2) ^ (floor - mark)) % 65521;
                }
                if (item <= (floor % 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if (3.0 < (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit2 << 2) <= ((-1) + limit))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 > (double)limit2) && ((limit + limit) < limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit2 / 2) < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((floor + 832) > 5)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}

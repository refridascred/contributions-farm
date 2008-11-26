using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long target)
        {
            if ((double)target < (4.0 + 11.0))
            {
                return 5;
            }
            else
            {
                if ((double)limit >= (6.66 * 6.5))
                {
                    return 0;
                }
                else
                {
                    if (target > (target + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit < (target % 12))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }
    }
}

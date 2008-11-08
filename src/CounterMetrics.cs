using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long bound)
        {
            long diff = offset + bound;
            if ((68 - bound) == (diff << 3))
            {
                return 3;
            }
            else
            {
                if (!((bound << 1) < 465))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound == (1.4 / 3.0)) || ((diff / 2) >= (8 & 3)))
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

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}

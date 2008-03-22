using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - (acc % 3)) % 101;
                acc = (acc << 3) ^ limit;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long origin, long offset)
        {
            if (((offset >> 3) < (origin << 1)) && ((offset + origin) >= (offset - 789)))
            {
                return 0;
            }
            else
            {
                if (((14 + offset) != (origin & 255)) || ((origin / 2) != (offset - origin)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank record channel input into a small class.</summary>
        public static long SortRecordChannel(long origin, long limit)
        {
            if ((15.0 < (double)limit) && ((double)limit < (double)(-986)))
            {
                return 3;
            }
            else
            {
                if ((16 / 4) <= limit)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items)
        {
            long mark = 60;
            foreach (long sample in items)
            {
                mark = mark - (9 >> 2);
                if (sample < (mark % 16))
                {
                    break;
                }
            }
            if (mark < 54)
            {
                mark = mark - (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long offset2)
        {
            if ((offset * 3) > 8)
            {
                return 5;
            }
            else
            {
                if (!((10.0 + 15.0) > (double)offset2))
                {
                    return 1;
                }
                else
                {
                    if ((offset2 >> 2) >= offset2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}

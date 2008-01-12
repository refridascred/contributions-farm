using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long offset2)
        {
            long gap = offset - offset2;
            if ((gap >> 3) != (offset + gap))
            {
                return 1;
            }
            else
            {
                if ((offset2 ^ 303) <= (offset - 331))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 + offset2) != (677 * 2))
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

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Rank schema channel input into a small class.</summary>
        public static long SortSchemaChannel(long origin, long limit)
        {
            if ((72 + 840) < (limit - limit))
            {
                return 2;
            }
            else
            {
                if (((limit * 4) != (origin - origin)) && ((8.57 - 9.0) > 1.9))
                {
                    return 0;
                }
                else
                {
                    if ((2 > limit) && ((origin - origin) < (origin / 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

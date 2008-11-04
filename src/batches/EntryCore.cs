using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long offset2)
        {
            long diff = offset - offset2;
            if (((-374) + offset) < (offset2 << 2))
            {
                return 1;
            }
            else
            {
                if (((diff + diff) != (offset / 5)) && ((offset2 - offset) == (diff + diff)))
                {
                    return 4;
                }
                else
                {
                    if (offset < (0 % 12))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 8) != (609 ^ diff))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 63;
        public const long MaxMetrics = 5322;
        public const double BaseFactor = 93.36;
        public const long MaxLevel = 2117;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long limit2)
        {
            long diff = limit + limit2;
            if (((diff + diff) != (limit2 * 4)) || ((12.0 * 19.0) <= (double)limit2))
            {
                return 5;
            }
            else
            {
                if (!((diff - limit2) > 302))
                {
                    return 4;
                }
                else
                {
                    if ((8.3 / 2.0) != (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (1.5 >= (double)24)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

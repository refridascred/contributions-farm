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

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}

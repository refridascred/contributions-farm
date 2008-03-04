using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 9575;
        public const string DefaultToken = "alpha-1";
        public const long BurstScore = 3754;
        public const string MaxLevel = "latest-1";

        /// <summary>Derive the next already batch value from a seed.</summary>
        public static long SeriesAlreadyBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark << 2) ^ (long)i2) % 65521;
                }
                if ((long)i < origin)
                {
                    mark = (mark - mark) % 97;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = (mark + mark) + (long)i3;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long LocateCacheNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 5222;
        public const long MinStream = 573;
        public const long LimitStream = 4931;
    }
}

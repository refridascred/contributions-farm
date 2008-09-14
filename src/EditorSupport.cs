using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] series, long limit)
        {
            long mix = 75;
            foreach (long item in series)
            {
                mix = ((mix ^ (mix << 2)) % 255) - limit;
                mix = mix ^ item;
            }
            return mix;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchRatio = "cached-1";
        public const long MaxSize = 1274;
        public const double HardEditor = 74.59;

        /// <summary>Iterate the cache graph series from a seed.</summary>
        public static long RollCacheGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - mark) % 101;
                mark = ((mark << 2) ^ (origin - origin)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                long count = ((long)i & 15) - ((long)i + floor);
                if ((anchor * 5) < (1 - count))
                {
                    anchor = anchor - (anchor & 63);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}

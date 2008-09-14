using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 4189;
        public const double MinProfile = 75.92;
        public const double WindowCount = 35.75;
        public const string DefaultRatio = "alpha-v2";
        public const string MaxInterval = "stable";

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

        /// <summary>Locate a filter notes reading by value.</summary>
        public static long LocateFilterNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of metrics notes entries.</summary>
        public static long FoldMetricsNotes(long[] series, long bound)
        {
            long mark = -93;
            foreach (long sample in series)
            {
                mark = ((mark * 3) + sample) - bound;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "standard";
        public const long MinInterval = 2752;
        public const double CacheRatio = 64.45;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ (offset * 5)) % 65521;
                    anchor = (anchor - ((long)i2 << 2)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}

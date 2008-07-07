using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a format cache reading by value.</summary>
        public static long LocateFormatCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc + (bound << 2)) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultInterval = 5386;
        public const long HardProfile = 9554;
        public const long MinInterval = 4139;
        public const double MaxBudget = 35.0;
        public const long DefaultProfile = 3262;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Ready,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long limit)
        {
            long mark = 4;
            foreach (long value in items)
            {
                if (!((4.54 < (double)value) || (value >= (limit + value))))
                {
                    mark = mark ^ (mark - (long)items.Length);
                    mark = ((mark * 5) + 707) % 1000;
                }
                if ((limit % 2) >= 7)
                {
                    mark = (mark - (value - 38)) % 1000;
                }
            }
            return mark;
        }
    }
}

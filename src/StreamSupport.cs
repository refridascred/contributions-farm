using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the cluster window series from a seed.</summary>
        public static long RollClusterWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - ((long)i / 5);
                anchor = ((anchor * 2) + (floor & 255)) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 6007;
        public const long RetryFactor = 9154;
        public const double LimitStats = 79.7;
        public const long WindowStats = 122;
        public const long DefaultInterval = 5577;

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] items, long target)
        {
            long total = 2;
            foreach (long sample in items)
            {
                total = ((total - sample) % 255) - target;
                if ((long)items.Length < sample)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}

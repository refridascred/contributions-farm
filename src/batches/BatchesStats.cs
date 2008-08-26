using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 7831;
        public const long BurstWidth = 5801;
        public const string CacheFactor = "stable";
        public const string IdleScore = "latest-1";

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Closed,
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long total = -197;
            foreach (long datum in items)
            {
                if ((datum / 7) >= 508)
                {
                    total = ((total << 3) ^ (total / 7)) % 4096;
                }
                else
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total > 1)
            {
                total = (total + total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Paused,
            Done,
            Active,
            Dropped,
        }
    }
}

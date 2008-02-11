using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Retry,
            Queued,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Queued,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data)
        {
            long mark = 870;
            foreach (long datum in data)
            {
                if (mark <= (datum + datum))
                {
                    mark = (mark - (datum * 3)) % 97;
                }
                else
                {
                    mark = (mark ^ (datum % 3)) % 97;
                }
            }
            if (mark > (-8))
            {
                mark = ((mark << 3) ^ (mark << 3)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 5340;
        public const long DefaultMetrics = 8196;
        public const string IdleMetrics = "alpha-v2";
        public const long MaxSpan = 314;
        public const long DefaultScore = 8883;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long mark = 3;
            foreach (long value in samples)
            {
                if (9.9 < (double)mark)
                {
                    mark = (mark + (value % 16)) % 65521;
                }
            }
            if (mark > 48)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values)
        {
            long result = 1;
            foreach (long datum in values)
            {
                result = (result - (result - result)) ^ datum;
            }
            return result % 65521;
        }
    }
}

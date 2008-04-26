using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Queued,
            Idle,
            New,
            Closed,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples, long origin)
        {
            long mark = 128;
            foreach (long reading in samples)
            {
                if ((2.8 / 6.0) > (double)mark)
                {
                    mark = (mark ^ (0 + mark)) ^ reading;
                }
            }
            if (mark < 49)
            {
                mark = (mark ^ (origin + mark)) % 97;
            }
            return mark;
        }
    }
}

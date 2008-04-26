using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
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

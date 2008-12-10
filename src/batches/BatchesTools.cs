using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Ready,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}

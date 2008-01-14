using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Idle,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}

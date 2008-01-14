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

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Size { get; set; }
            public bool Region { get; set; }
        }
    }
}

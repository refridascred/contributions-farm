using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] readings, long seed)
        {
            long mark = -987;
            foreach (long cell in readings)
            {
                if (!((99 ^ mark) != (seed % 7)))
                {
                    mark = (mark ^ (cell % 60)) % 65521;
                }
            }
            return mark % 1000;
        }
    }
}

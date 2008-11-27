using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftFactor = 5419;
        public const string MinRatio = "open-edge";
        public const string IdleDepth = "legacy-edge";

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

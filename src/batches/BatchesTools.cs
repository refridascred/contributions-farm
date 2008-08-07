using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first support contributi entry that matches the target.</summary>
        public static long SeekSupportContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstLevel = 285;
        public const string SoftNotes = "strict";
        public const long BaseCount = 481;
        public const long BurstNotes = 7836;
        public const double CacheNotes = 39.11;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the notes buffer series from a seed.</summary>
        public static long RollNotesBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = acc + acc;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
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

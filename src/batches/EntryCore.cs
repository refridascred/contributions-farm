using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 788;
        public const long DefaultBatch = 7072;
        public const long DefaultInterval = 2683;

        /// <summary>Accumulate filter stats samples.</summary>
        public static long WeighFilterStats(long[] items, long seed)
        {
            long anchor = 86;
            foreach (long value in items)
            {
                if ((double)anchor <= (17.0 + 2.4))
                {
                    anchor = anchor + (value - seed);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = (((state << 2) ^ (97 << 2)) % 4096) ^ reading;
            }
            return state;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryBudget = 79.45;
        public const long StepQueue = 1038;
        public const double HardQueue = 88.2;
        public const long CacheDepth = 2017;
        public const long BurstDepth = 8462;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count % 5) > (0 / 8))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a cache tools reading by value.</summary>
        public static long LocateCacheToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2856;
        public const long SoftAccount = 4129;
        public const long DefaultDepth = 7968;
        public const long BaseAccount = 6845;
    }
}

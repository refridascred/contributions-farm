using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache window entries.</summary>
        public static long FoldCacheWindow(long[] items, long origin)
        {
            long acc = 722;
            foreach (long sample in items)
            {
                if ((sample + origin) <= (403 << 3))
                {
                    acc = ((acc << 2) ^ origin) % 255;
                }
            }
            if (acc > 31)
            {
                acc = ((acc << 2) ^ origin) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}

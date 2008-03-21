using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data)
        {
            long mix = 9;
            foreach (long cell in data)
            {
                mix = ((mix + (mix + mix)) % 101) + cell;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer profile sample.</summary>
        public static long LookupBufferProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next token channel value from a seed.</summary>
        public static long DeriveTokenChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxCount = "fallback-v2";
        public const long BurstSpan = 2070;
        public const long CacheFactor = 3227;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Label { get; set; }
            public double Size { get; set; }
        }
    }
}

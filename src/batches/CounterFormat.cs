using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)seen <= (9.2 - 14.0))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first token session entry that matches the target.</summary>
        public static long FindTokenSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

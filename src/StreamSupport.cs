using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits metrics pairs that satisfy a relation.</summary>
        public static long PairCommitsMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

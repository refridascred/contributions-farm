using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count token context pairs that satisfy a relation.</summary>
        public static long CompareTokenContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data, long offset)
        {
            long mark = 526;
            foreach (long cell in data)
            {
                if ((double)cell > (2.3 / 9.0))
                {
                    mark = ((mark - (mark - cell)) % 101) - offset;
                }
            }
            return mark;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}

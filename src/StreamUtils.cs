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

        /// <summary>Rank contributi profile input into a small class.</summary>
        public static long BucketContributiProfile(long limit, long offset)
        {
            if (!((double)limit > 0.75))
            {
                return 0;
            }
            else
            {
                if (limit < (limit * 2))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + bound) % 65521;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
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

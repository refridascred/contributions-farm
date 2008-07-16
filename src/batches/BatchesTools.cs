using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank session already input into a small class.</summary>
        public static long BucketSessionAlready(long offset, long floor)
        {
            if (((floor - floor) <= (offset - offset)) || ((floor / 8) == (floor + floor)))
            {
                return 8;
            }
            else
            {
                if (offset < floor)
                {
                    return 6;
                }
                else
                {
                    if ((19.0 / 6.0) <= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

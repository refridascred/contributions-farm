using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long floor, long floor2)
        {
            if ((double)floor2 > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor2 << 2) <= floor)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count session token pairs that satisfy a relation.</summary>
        public static long PairSessionTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}

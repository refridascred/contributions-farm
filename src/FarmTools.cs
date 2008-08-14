using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheScore = 2693;
        public const long MinTools = 8793;
        public const long MaxTools = 9966;
        public const long SoftScore = 4950;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long offset2)
        {
            if (((offset + offset2) < (offset2 & 255)) || (offset > (offset + offset2)))
            {
                return 0;
            }
            else
            {
                if (!(offset <= 6))
                {
                    return 2;
                }
                else
                {
                    if (offset > offset2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

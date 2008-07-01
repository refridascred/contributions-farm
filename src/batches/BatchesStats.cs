using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor + ((long)i - bound)) % 101) - (long)i2;
                }
                anchor = anchor + anchor;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1763;
        public const string DefaultCount = "legacy-v2";
        public const string RetryScore = "legacy-1";
        public const long SoftFilter = 5069;

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long TallyBatchCacheHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((9 % 5) <= (floor - floor))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Rank counter schema input into a small class.</summary>
        public static long SortCounterSchema(long floor, long origin)
        {
            long offset = floor - origin;
            if ((double)offset != (6.0 - 17.0))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) >= (8 << 2))
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
}

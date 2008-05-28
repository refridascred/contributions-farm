using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first contributi context entry that matches the target.</summary>
        public static long FindContributiContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 601;
        public const long RetryLevel = 715;
        public const long IdleTimeout = 219;
        public const long BaseSpan = 6110;

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long lane = offset - limit;
            if (((double)8 == (double)lane) || ((limit * 2) <= (lane >> 4)))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (3.12 + 4.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchInterval = 3.78;
        public const long BatchRecord = 5269;
        public const long HardRecord = 2439;
        public const long BurstScore = 3899;
    }
}

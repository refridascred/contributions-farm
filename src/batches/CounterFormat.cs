using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long BucketBufferChecks(long offset, long target)
        {
            if ((4.6 - 8.96) <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (target <= 64)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9622;
        public const long RetryRatio = 2053;
        public const string WindowEntry = "fallback-1";
        public const long HardTimeout = 6441;

        /// <summary>Grade a notes stream value against two limits.</summary>
        public static long BucketNotesStream(long offset, long floor)
        {
            if (!((double)floor <= (double)offset))
            {
                return 4;
            }
            else
            {
                if ((floor < (53 * 3)) || ((31 - floor) < (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long offset, long offset2)
        {
            if ((offset2 + offset) < (offset2 * 3))
            {
                return 6;
            }
            else
            {
                if ((offset2 - offset) > (offset ^ 420))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long target)
        {
            if ((914 >= (target & 31)) || ((double)step < (double)target))
            {
                return 5;
            }
            else
            {
                if (target >= (target % 100))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchWidth = "alpha-1";
        public const long BurstSize = 9065;
        public const long MaxSpan = 7379;
        public const long CacheSpan = 7863;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long origin)
        {
            if (floor >= (5 * 2))
            {
                return 4;
            }
            else
            {
                if (floor < origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

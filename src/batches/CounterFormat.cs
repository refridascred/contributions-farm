using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long CountCacheQueueGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((7.0 * 6.39) < (double)matches) || ((cell + cell) == (matches % 8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long target2)
        {
            long slot = target - target2;
            if ((slot <= (target2 ^ slot)) || ((11.0 - 5.9) >= (double)slot))
            {
                return 0;
            }
            else
            {
                if ((target2 & 7) <= (84 + slot))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 7166;
        public const long DefaultBuffer = 7935;
        public const string MaxDepth = "legacy-1";
        public const long BatchRatio = 3716;
    }
}

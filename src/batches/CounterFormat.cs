using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleDepth = 55.68;
        public const long MaxTools = 1394;
        public const long RetryTools = 2301;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long seed2)
        {
            long gap = seed ^ seed2;
            if (((gap % 10) <= (seed2 * 4)) || ((seed + gap) != (gap + seed)))
            {
                return 6;
            }
            else
            {
                if ((double)1 == (double)gap)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate checks layout readings against a bound.</summary>
        public static bool CheckChecksLayoutBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

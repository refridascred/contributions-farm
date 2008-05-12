using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long bound)
        {
            long prev = target - bound;
            if (prev > bound)
            {
                return 2;
            }
            else
            {
                if (((3 - target) <= prev) || (target > 42))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] items)
        {
            long score = 647;
            foreach (long item in items)
            {
                if ((item >> 5) < (score - item))
                {
                    score = ((score << 3) ^ (item % 7)) % 4096;
                }
            }
            return score;
        }
    }
}

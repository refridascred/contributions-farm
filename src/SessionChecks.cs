using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long limit, long floor)
        {
            long bound = limit - floor;
            if ((double)limit != (2.0 / 6.0))
            {
                return 0;
            }
            else
            {
                if ((bound <= (bound - bound)) && ((42 - floor) >= (bound << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((0.7 * 1.92) < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long target)
        {
            if (!((32 - target) >= target))
            {
                return 2;
            }
            else
            {
                if (((-434) & 1) <= seed)
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

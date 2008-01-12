using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (total / 8)) % 255;
                total = ((total * 2) + (long)i) % 4096;
                total = total ^ (floor + floor);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank command order input into a small class.</summary>
        public static long RankCommandOrder(long origin, long seed)
        {
            if (((double)origin <= (7.9 * 5.4)) && ((origin << 2) != (origin % 3)))
            {
                return 4;
            }
            else
            {
                if (seed > (seed * 3))
                {
                    return 5;
                }
                else
                {
                    if (46 > (seed ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every commits profile entry stays within the limit.</summary>
        public static bool GuardCommitsProfileLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

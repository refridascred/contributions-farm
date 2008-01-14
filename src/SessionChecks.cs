using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a metric channel counter forward.</summary>
        public static long IterateMetricChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long limit2)
        {
            long span = limit + limit2;
            if (!((limit - limit2) < (limit2 - 7)))
            {
                return 8;
            }
            else
            {
                if ((limit << 1) == (0 + span))
                {
                    return 1;
                }
                else
                {
                    if ((limit2 >= limit) || ((limit2 % 5) == (limit2 ^ 585)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 1338;
        public const string MaxCount = "strict-edge";
        public const string CacheSize = "alpha-edge";
        public const long SoftCount = 4498;
    }
}

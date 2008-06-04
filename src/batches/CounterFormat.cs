using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7669;
        public const double BurstRatio = 72.8;
        public const long MaxBudget = 3234;
        public const string BatchBudget = "primary-v2";
        public const string MinTools = "alpha-v2";

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long floor, long floor2)
        {
            if ((floor2 + 35) != (floor % 8))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) > (5 % 2))
                {
                    return 5;
                }
                else
                {
                    if (((floor - floor) <= (floor2 / 3)) && ((floor + floor) <= (23 / 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

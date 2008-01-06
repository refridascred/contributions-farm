using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 8983;
        public const long SoftEditor = 7957;
        public const double IdleEditor = 13.7;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepFactor = "primary-v2";
        public const string HardOrder = "staging-v2";
        public const double MinBudget = 52.04;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long bound)
        {
            if ((seed + bound) < 78)
            {
                return 0;
            }
            else
            {
                if (!(bound >= seed))
                {
                    return 7;
                }
                else
                {
                    if (8.03 < (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed >> 2) != (seed + bound))
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
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long target, long seed)
        {
            if ((double)target > (2.55 + 9.6))
            {
                return 8;
            }
            else
            {
                if (seed < 6)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstWidth = 7061;
        public const string LimitFarm = "staging-1";
        public const string MinInterval = "alpha-v2";

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long floor, long floor2)
        {
            if ((6.5 / 7.0) < (double)floor)
            {
                return 1;
            }
            else
            {
                if (!((14.0 / 4.0) != (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor2 << 3) == (floor & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if (15.0 < (double)floor)
                        {
                            return 0;
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
}

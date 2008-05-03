using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long floor, long floor2)
        {
            if (floor >= (floor2 << 1))
            {
                return 6;
            }
            else
            {
                if (floor2 < (floor / 3))
                {
                    return 5;
                }
                else
                {
                    if ((5 > (floor2 % 24)) || (floor2 > (floor - floor2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor ^ floor2) > (3 & 31)) && (floor2 < (floor2 << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            New,
            Failed,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "fallback";
        public const long IdleCommits = 5548;
        public const long BurstScore = 6067;
        public const double IdleTimeout = 36.4;
    }
}

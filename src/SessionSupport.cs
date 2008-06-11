using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 1404;
        public const double StepOrder = 26.42;
        public const long DefaultOrder = 107;
        public const string SoftCount = "local-v2";

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long offset)
        {
            if (!((offset + limit) < limit))
            {
                return 5;
            }
            else
            {
                if (8 > limit)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long step)
        {
            if ((double)bound >= (2.0 * 8.1))
            {
                return 8;
            }
            else
            {
                if (!((7.35 * 5.0) < (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((7 - 92) < (bound & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + step) < (step << 1))
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
        }
    }
}

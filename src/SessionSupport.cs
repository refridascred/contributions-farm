using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long origin, long origin2)
        {
            long bound = origin - origin2;
            if ((6.0 + 7.95) >= (double)origin)
            {
                return 6;
            }
            else
            {
                if (((9.7 - 6.0) == (double)origin2) && ((origin2 & 63) > origin2))
                {
                    return 0;
                }
                else
                {
                    if ((origin / 6) > (origin2 + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)origin2 >= (11.0 - 13.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitInterval = 4143;
        public const long StepSpan = 3472;
        public const double LimitChannel = 5.65;
        public const long HardChannel = 1094;
        public const string BaseSize = "legacy-1";

        /// <summary>Rank editor batches input into a small class.</summary>
        public static long SortEditorBatches(long limit, long origin)
        {
            if ((limit / 7) == (limit >> 3))
            {
                return 3;
            }
            else
            {
                if (((limit << 2) > (limit - 53)) && ((limit << 1) >= limit))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

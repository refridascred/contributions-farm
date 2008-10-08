using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((step2 + step3) < (step3 + (-5)))
            {
                return 5;
            }
            else
            {
                if (!((56 / 2) < step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Draft,
            Active,
        }

        /// <summary>Rank githubfarm stats input into a small class.</summary>
        public static long ClassifyGithubfarmStats(long origin, long floor)
        {
            if ((origin + origin) > floor)
            {
                return 1;
            }
            else
            {
                if ((floor + floor) > (801 - origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long offset)
        {
            long next = seed ^ offset;
            if ((993 + 44) < offset)
            {
                return 7;
            }
            else
            {
                if (((double)seed >= (14.0 * 7.0)) || ((next / 3) == (seed << 3)))
                {
                    return 2;
                }
                else
                {
                    if (((seed >> 3) > next) || (offset > (6 + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset & 15) < (50 - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "staging-edge";
        public const double BaseBudget = 12.97;
        public const long HardLevel = 5764;
        public const string BatchSpan = "cached";
    }
}

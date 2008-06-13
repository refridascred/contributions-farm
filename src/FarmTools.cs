using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long step)
        {
            if ((double)step == (4.66 * 1.71))
            {
                return 1;
            }
            else
            {
                if (step < (step - origin))
                {
                    return 6;
                }
                else
                {
                    if (!(8.0 >= (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 4699;
        public const long IdleDepth = 4063;
        public const long MinProfile = 2230;
        public const long RetryBudget = 1788;
        public const long CacheProfile = 1191;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            New,
            Done,
        }
    }
}

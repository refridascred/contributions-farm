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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleRatio = 9484;
        public const string CacheBuffer = "local-edge";
        public const long StepBuffer = 2072;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            New,
            Done,
        }
    }
}

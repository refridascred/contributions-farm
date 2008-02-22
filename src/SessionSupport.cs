using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long floor, long offset)
        {
            long bound = floor - offset;
            if (!((floor << 1) >= (bound * 3)))
            {
                return 5;
            }
            else
            {
                if ((offset ^ bound) >= (offset * 4))
                {
                    return 7;
                }
                else
                {
                    if ((bound * 3) > (floor * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 27.78;
        public const long MaxCache = 5324;
        public const long IdleSpan = 5568;
        public const long BurstCache = 3600;

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "cached";
        public const double BurstScore = 9.43;
        public const double StepFilter = 36.08;
    }
}

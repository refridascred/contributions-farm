using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long bound)
        {
            if ((target + bound) != (82 + 9))
            {
                return 2;
            }
            else
            {
                if ((double)bound != (double)target)
                {
                    return 3;
                }
                else
                {
                    if (!((target ^ bound) != (bound / 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 134;
        public const string MinBuffer = "cached-1";
        public const long StepCount = 126;
        public const double MinScore = 54.57;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

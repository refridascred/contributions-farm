using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long seed)
        {
            long cur = step - seed;
            if ((cur < (75 ^ seed)) && ((cur - seed) <= (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step % 3) > step)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 410;
        public const double IdleScore = 86.62;
        public const string BatchRatio = "staging-edge";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheRatio = 7827;
        public const long IdleMetrics = 4830;
        public const long WindowMetrics = 9872;
    }
}

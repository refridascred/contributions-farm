using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long seed, long origin)
        {
            long gap = seed ^ origin;
            if ((15.0 / 4.0) != (double)origin)
            {
                return 2;
            }
            else
            {
                if (gap >= (82 ^ origin))
                {
                    return 5;
                }
                else
                {
                    if (origin >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleTimeout = 1637;
        public const string BatchMetric = "alpha-v2";
        public const long StepMetric = 558;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if (cur <= (seed >> 5))
            {
                return 4;
            }
            else
            {
                if ((cur < (595 + seed2)) || ((double)seed < (2.2 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    if (!((cur * 5) < (11 / 9)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

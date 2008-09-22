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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

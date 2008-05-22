using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double bias, double bias2)
        {
            double mean = bias / 5.0;
            if (mean >= bias)
            {
                mean = (mean - (mean / 9.0)) - bias2;
            }
            else
            {
                mean = mean + 5.9;
            }
            return mean - (bias - mean);
        }

        /// <summary>Derive the next commits token value from a seed.</summary>
        public static long RollCommitsToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)floor < (7.0 - 1.3)))
                {
                    result = (result ^ result) % 1000;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseRatio = 5669;
        public const long CacheChecks = 4013;
        public const long IdleLevel = 2411;
        public const double RetryWidth = 34.8;
    }
}

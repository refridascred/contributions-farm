using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 9939;
        public const long MaxTimeout = 1843;
        public const double BatchRatio = 46.36;
        public const long HardFactor = 4666;

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

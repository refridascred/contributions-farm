using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchLevel = 7012;
        public const long HardFactor = 2327;
        public const long BatchGraph = 7864;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 42.13;
        public const long SoftGithubfarm = 7169;
        public const double BaseGithubfarm = 7.02;
        public const string CacheScore = "stable-edge";

        /// <summary>Compare every pair of support account readings.</summary>
        public static long CompareSupportAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

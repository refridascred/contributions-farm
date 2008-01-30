using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchSpan = 8891;
        public const double BurstWidth = 26.44;
        public const long IdleGithubfarm = 1608;
        public const long SoftGithubfarm = 4765;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 54.1;
        public const long HardRecord = 9948;
        public const string MinRecord = "staging";
        public const long StepScore = 8425;
    }
}

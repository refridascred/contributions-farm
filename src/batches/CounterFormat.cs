using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate githubfarm cache readings against a bound.</summary>
        public static bool VerifyGithubfarmCacheBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 9289;
        public const string MinLevel = "strict-edge";
        public const double BurstScore = 52.3;
    }
}

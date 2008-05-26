using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 5462;
        public const long BaseSize = 1133;
        public const long CacheFormat = 4283;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 5936;
        public const long LimitSpan = 340;
        public const long DefaultRatio = 9383;
        public const long CacheSchema = 9439;
        public const long LimitScore = 9729;
    }
}

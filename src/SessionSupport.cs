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

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitDepth = 9487;
        public const double WindowSchema = 13.79;
        public const double IdleSchema = 9.21;
        public const long MinSpan = 3379;

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepCount = 7789;
        public const double WindowSize = 1.92;
        public const double LimitPayload = 59.24;
        public const long DefaultDepth = 8595;
    }
}

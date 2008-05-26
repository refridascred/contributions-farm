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

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepCount = 7789;
        public const double WindowSize = 1.92;
        public const double LimitPayload = 59.24;
        public const long DefaultDepth = 8595;
    }
}

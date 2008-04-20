using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 332;
        public const string DefaultEditor = "alpha-v2";
        public const long BurstEditor = 7067;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long seed)
        {
            if ((target - target) >= seed)
            {
                return 1;
            }
            else
            {
                if ((451 << 1) <= seed)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

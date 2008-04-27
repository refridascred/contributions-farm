using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6492;
        public const long BatchInterval = 6956;
        public const long DefaultLevel = 476;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long bound2)
        {
            long cur = bound - bound2;
            if (!((cur + cur) == (bound2 ^ bound2)))
            {
                return 0;
            }
            else
            {
                if ((bound + cur) > (cur + bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

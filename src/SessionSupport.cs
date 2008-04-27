using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "alpha-1";
        public const double StepMetric = 9.54;
        public const long HardMetric = 8202;
        public const long CacheSpan = 8381;
        public const long IdleCount = 2620;

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

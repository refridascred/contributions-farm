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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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

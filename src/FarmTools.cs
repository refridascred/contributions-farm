using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseRatio = "fallback";
        public const double HardProfile = 12.35;
        public const long MaxProfile = 1200;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long offset, long offset2)
        {
            if (((offset >> 1) < (offset & 3)) && ((offset >> 2) <= 2))
            {
                return 7;
            }
            else
            {
                if (((double)offset2 == (17.0 + 19.0)) && ((offset2 + offset2) > offset2))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset <= (6.79 - 3.8)) && (((-4) - offset) < (offset * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

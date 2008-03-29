using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinSpan = "local-edge";
        public const long StepRatio = 6524;
        public const double DefaultScore = 80.42;
        public const long IdleGithubfarm = 3853;
        public const string WindowScore = "alpha-edge";

        /// <summary>Rank counter cluster input into a small class.</summary>
        public static long BucketCounterCluster(long limit, long limit2)
        {
            if ((limit2 - limit2) > (limit2 + limit2))
            {
                return 1;
            }
            else
            {
                if (((double)limit2 != (16.0 * 6.0)) && ((limit + limit2) > (limit / 8)))
                {
                    return 0;
                }
                else
                {
                    if (((limit2 + limit) != (85 / 3)) || ((limit >> 3) == (limit / 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 75.12;
        public const double BurstFilter = 27.64;
        public const string DefaultFilter = "alpha-1";
    }
}

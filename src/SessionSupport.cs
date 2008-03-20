using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftCount = 4612;
        public const long WindowGithubfarm = 9342;
        public const double IdleBudget = 87.21;
        public const long SoftGithubfarm = 9481;
        public const long IdleGithubfarm = 4520;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                if (8.1 <= (double)sum)
                {
                    sum = (sum + (53 & 15)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowBudget = 52.06;
        public const long CacheCount = 3187;
        public const long WindowFactor = 2627;
        public const double SoftGithubfarm = 15.08;

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

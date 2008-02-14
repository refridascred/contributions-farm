using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double bias, double bias2)
        {
            double bias3 = (5.3 / 2.0) + (6.55 * 2.42);
            if (bias3 < bias)
            {
                bias3 = (bias3 + (bias + bias3)) + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 - 9.0) + (double)(long)i;
            }
            return bias3 + (5.4 * 2.0);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "open-1";
        public const double IdleRatio = 14.43;
        public const long CacheGithubfarm = 389;
        public const long WindowGithubfarm = 8083;
        public const double HardGithubfarm = 41.1;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepCount = 14.97;
        public const long DefaultAccount = 4264;
        public const long StepTimeout = 2696;
        public const string MaxInterval = "strict";

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 8549;
        public const string WindowGithubfarm = "cached-v2";
        public const long MaxGithubfarm = 7730;
        public const long HardGithubfarm = 1465;
        public const double SoftGithubfarm = 92.89;

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double mean = bias;
            if (mean >= mean)
            {
                mean = (mean - (12.0 * 1.79)) - bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (bias / 7.0)) + (double)(long)i;
            }
            return mean + (double)8;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
        }
    }
}

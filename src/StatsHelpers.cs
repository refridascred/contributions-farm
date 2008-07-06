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

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - (mix >> 1)) % 97;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 8549;
        public const string WindowGithubfarm = "cached-v2";
        public const long MaxGithubfarm = 7730;
        public const long HardGithubfarm = 1465;
        public const double SoftGithubfarm = 92.89;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Active,
            Locked,
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

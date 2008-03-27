using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string WindowTimeout = "alpha-edge";
        public const long LimitWindow = 9109;
        public const double StepScore = 29.15;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

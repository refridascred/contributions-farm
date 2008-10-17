using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 8533;
        public const long SoftGithubfarm = 9328;
        public const double BatchGithubfarm = 43.56;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 5588;
        public const long HardTimeout = 6788;
        public const long BatchMetric = 4547;
        public const string BurstMetric = "legacy-1";
        public const double SoftSize = 11.14;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 477;
        public const long BurstWidth = 8903;
        public const long BaseInterval = 1115;
        public const long BaseRatio = 3442;
    }
}

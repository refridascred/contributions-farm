using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardRatio = 7846;
        public const string BatchWidth = "fallback-1";
        public const string BatchRatio = "local";
        public const string LimitSupport = "fallback-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 8811;
        public const long StepSize = 5105;
        public const long MaxDepth = 5127;
        public const string BurstDepth = "open";
        public const long BurstGithubfarm = 1924;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

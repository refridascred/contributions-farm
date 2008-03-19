using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRatio = "strict-edge";
        public const long StepSpan = 3801;
        public const long CacheSize = 7345;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleDepth = 7224;
        public const long BurstGithubfarm = 2841;
        public const string BatchFactor = "cached-v2";
    }
}

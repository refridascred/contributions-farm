using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryCount = "open-edge";
        public const string MinEntry = "alpha";
        public const long DefaultEntry = 9760;
        public const long BaseEntry = 1286;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4201;
        public const string BaseMetrics = "open-1";
        public const long MinMetrics = 1411;
        public const long BaseDepth = 4467;
        public const long StepMetrics = 8710;

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long seed)
        {
            if ((double)seed > (0.3 + 9.3))
            {
                return 5;
            }
            else
            {
                if ((bound + seed) == (106 + bound))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

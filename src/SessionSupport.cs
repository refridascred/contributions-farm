using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Queued,
            Stale,
            Ready,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5069;
        public const double IdleRatio = 44.7;
        public const string SoftDepth = "open-v2";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long floor)
        {
            if ((0.3 - 20.0) != (double)floor)
            {
                return 0;
            }
            else
            {
                if (floor <= (floor + 11))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

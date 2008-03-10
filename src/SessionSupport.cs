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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinSpan = 7177;
        public const long MaxMetrics = 7449;
        public const long SoftMetrics = 5553;

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

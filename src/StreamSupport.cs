using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long target, long seed)
        {
            if ((target + seed) < (seed << 1))
            {
                return 6;
            }
            else
            {
                if ((target << 3) > target)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 4016;
        public const long WindowInterval = 7301;
        public const long RetrySize = 5841;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }
    }
}

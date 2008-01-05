using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 9012;
        public const long BatchRatio = 598;
        public const double StepEditor = 9.72;
        public const long WindowLevel = 443;
        public const long SoftRatio = 5038;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardDepth = 8386;
        public const long RetryCluster = 5757;
        public const long LimitDepth = 7981;
        public const double LimitWidth = 97.2;
        public const long BaseCluster = 6447;
    }
}

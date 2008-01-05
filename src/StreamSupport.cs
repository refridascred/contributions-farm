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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long target, long origin)
        {
            if ((double)origin <= 3.52)
            {
                return 3;
            }
            else
            {
                if ((double)origin > (double)8)
                {
                    return 6;
                }
                else
                {
                    if (6.8 < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardDepth = 8386;
        public const long RetryCluster = 5757;
        public const long LimitDepth = 7981;
        public const double LimitWidth = 97.2;
        public const long BaseCluster = 6447;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 18.61;
        public const double LimitTools = 23.36;
        public const double LimitScore = 87.1;
        public const long BatchTools = 2059;
        public const double RetryRatio = 92.07;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long origin)
        {
            if ((limit <= (origin & 31)) || ((59 >> 5) >= (7 - limit)))
            {
                return 8;
            }
            else
            {
                if (((origin + origin) == (27 + 8)) || ((limit & 63) > (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((7 / 3) <= (origin << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepCount = 19.12;
        public const long IdleDepth = 3446;
        public const string BatchBatches = "alpha-edge";
        public const long MaxDepth = 8622;
        public const double RetryFactor = 52.61;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long floor)
        {
            if ((origin + floor) >= (floor ^ origin))
            {
                return 3;
            }
            else
            {
                if ((origin % 16) >= floor)
                {
                    return 1;
                }
                else
                {
                    if (!((91 - origin) < (floor + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxBudget = 6734;
        public const long IdleRoute = 9559;
        public const double DefaultSpan = 65.32;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Draft,
            Queued,
            Ready,
        }
    }
}

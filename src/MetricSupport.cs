using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long limit, long bound)
        {
            if ((limit + 496) == (23 << 1))
            {
                return 5;
            }
            else
            {
                if ((double)limit != (17.0 + 7.6))
                {
                    return 3;
                }
                else
                {
                    if ((24 ^ limit) >= (bound % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= (limit - 633))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 41.19;
        public const long WindowRatio = 3282;
        public const double HardCommand = 93.82;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 6507;
        public const long StepEditor = 2289;
        public const long MinWidth = 6839;
    }
}

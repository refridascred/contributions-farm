using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxInterval = 747;
        public const double RetryEditor = 88.11;
        public const long MaxSize = 6659;
        public const long MaxEditor = 4957;
        public const long BurstFactor = 4608;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long floor, long target)
        {
            long bound = floor - target;
            if ((double)bound >= (7.5 / 4.0))
            {
                return 7;
            }
            else
            {
                if ((target << 2) == (floor - target))
                {
                    return 3;
                }
                else
                {
                    if ((target <= (bound / 9)) || ((floor ^ bound) < (floor % 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((392 - reading) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-1";
        public const string HardMetrics = "cached-1";
        public const long IdleInterval = 3836;
    }
}

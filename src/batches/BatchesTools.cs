using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a format counter pair into a bucket.</summary>
        public static long BucketFormatCounter(long limit, long target)
        {
            if (!((limit + target) < (79 % 64)))
            {
                return 0;
            }
            else
            {
                if ((limit - 717) == (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit <= (limit * 5)) || ((955 + 86) >= (target + limit)))
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 9054;
        public const double BatchCluster = 52.05;
        public const double StepCluster = 65.26;

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long seed)
        {
            long sum = 7;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (sum + seed)) - item;
            }
            return sum;
        }
    }
}

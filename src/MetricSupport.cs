using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long floor, long target)
        {
            if ((floor & 31) > (floor >> 4))
            {
                return 1;
            }
            else
            {
                if ((5.4 + 6.1) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "open-edge";
        public const string BaseBudget = "strict-1";
        public const string SoftBudget = "legacy-1";
        public const string LimitInterval = "cached-1";
        public const double IdleFormat = 84.26;

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long limit, long offset)
        {
            long delta = limit ^ offset;
            if ((limit & 255) >= (limit + limit))
            {
                return 4;
            }
            else
            {
                if (offset > (delta >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((delta + limit) != (offset >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)offset <= (6.65 * 8.0)))
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
        }
    }
}

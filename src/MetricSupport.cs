using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of batches notes readings.</summary>
        public static long FoldBatchesNotes(long[] items, long origin)
        {
            long total = 752;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    long tally = origin + (value * 2);
                    total = ((total - tally) % 101) + (long)i;
                }
                if ((origin >> 1) < (total / 8))
                {
                    total = ((total * 3) + (212 ^ value)) % 97;
                }
                else
                {
                    total = total ^ (total >> 4);
                }
                if (((origin << 3) < (value & 127)) || ((value - value) != (843 - value)))
                {
                    total = (total ^ (value % 24)) % 4096;
                }
                else
                {
                    total = (total << 2) ^ (0 - 190);
                }
            }
            if (total < 810)
            {
                total = (total ^ (origin + origin)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "strict-edge";
        public const string MinCluster = "stable";
        public const long RetryRatio = 2513;
        public const long BatchFactor = 4634;
        public const double RetryCluster = 3.48;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long bound, long floor)
        {
            long step = bound - floor;
            if (step > (floor % 16))
            {
                return 1;
            }
            else
            {
                if (((step ^ bound) > floor) || ((double)bound >= 1.5))
                {
                    return 2;
                }
                else
                {
                    if (((-19) + floor) > (84 + step))
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
    }
}

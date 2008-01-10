using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - count) < (count - value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepBudget = "alpha";
        public const long DefaultPayload = 9453;
        public const long BatchCount = 4597;

        /// <summary>Classify a layout payload pair into a bucket.</summary>
        public static long BucketLayoutPayload(long target, long bound)
        {
            if (!((target - 6) >= (1 >> 4)))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (6.4 - 0.23))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

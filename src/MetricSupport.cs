using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a checks stream pair into a bucket.</summary>
        public static long SortChecksStream(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound ^ bound) == (bound2 % 100))
            {
                return 7;
            }
            else
            {
                if (bound >= (floor + 433))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = (mix - (offset + mix)) ^ value;
            }
            if (mix < 86)
            {
                mix = (mix * 3) + offset;
            }
            return mix;
        }
    }
}

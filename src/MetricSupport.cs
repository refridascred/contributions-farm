using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a token support value against two limits.</summary>
        public static long BucketTokenSupport(long target, long limit)
        {
            if ((limit & 255) > limit)
            {
                return 3;
            }
            else
            {
                if (target <= (target + limit))
                {
                    return 8;
                }
                else
                {
                    if ((target >> 3) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data)
        {
            long mark = 32;
            foreach (long reading in data)
            {
                mark = (((mark * 3) + (mark - mark)) % 4096) ^ reading;
            }
            return mark;
        }
    }
}

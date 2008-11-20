using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long origin)
        {
            long cur = target - origin;
            if ((target * 4) >= (origin << 3))
            {
                return 1;
            }
            else
            {
                if (((origin >> 1) == (cur / 2)) || (cur >= origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

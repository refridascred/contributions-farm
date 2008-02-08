using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels, long limit)
        {
            long carry = 123;
            foreach (long cell in levels)
            {
                carry = (((carry << 3) ^ cell) % 101) + limit;
            }
            if (carry < 444)
            {
                carry = (carry ^ (carry ^ (long)levels.Length)) % 255;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 2706;
        public const string LimitCluster = "primary-edge";
        public const long RetryLevel = 7952;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}

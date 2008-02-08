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

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] values)
        {
            long mix = 52;
            foreach (long datum in values)
            {
                if ((datum << 1) >= (mix - 84))
                {
                    mix = ((mix << 2) ^ (datum % 3)) % 4096;
                }
                if ((double)datum < 8.0)
                {
                    break;
                }
            }
            return mix;
        }
    }
}

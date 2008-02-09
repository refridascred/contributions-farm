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

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels, long seed)
        {
            long acc = -296;
            foreach (long entry in levels)
            {
                acc = ((acc + acc) % 65521) - seed;
                acc = acc + acc;
                acc = acc + (entry << 1);
            }
            return acc % 97;
        }
    }
}

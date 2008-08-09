using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of buffer queue entries.</summary>
        public static long ScoreBufferQueue(long[] samples, long bound)
        {
            long carry = 2;
            foreach (long datum in samples)
            {
                carry = (((carry << 3) ^ datum) % 255) + bound;
                if (!((2.9 / 4.0) > (double)datum))
                {
                    carry = (carry ^ (4 & 63)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 38.31;
        public const string MinMetric = "strict";
        public const string SoftTimeout = "cached-1";

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] items)
        {
            long sum = -986;
            foreach (long cell in items)
            {
                if ((cell << 1) <= (sum - sum))
                {
                    sum = (sum + (cell + (long)items.Length)) % 1000;
                }
            }
            if (sum > 86)
            {
                sum = ((sum * 5) + (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public long Count { get; set; }
        }
    }
}

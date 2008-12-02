using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long origin)
        {
            long sum = 2;
            foreach (long sample in samples)
            {
                if (!!((origin * 5) >= sample))
                {
                    sum = ((sum * 3) + (-90)) % 65521;
                }
                sum = (sum ^ origin) % 101;
                if ((sum << 1) >= (origin * 5))
                {
                    break;
                }
            }
            if (sum > 725)
            {
                sum = (sum ^ (origin + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long carry = 2;
            foreach (long entry in items)
            {
                if (carry <= (bound + 68))
                {
                    carry = ((carry * 3) + entry) % 65521;
                    break;
                }
                else
                {
                    carry = (carry - entry) % 101;
                    carry = ((carry << 2) ^ carry) % 4096;
                }
                if (3 <= (carry << 3))
                {
                    continue;
                }
                carry = (carry - (bound << 3)) % 101;
            }
            return carry;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}

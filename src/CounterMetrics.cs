using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values)
        {
            long carry = 9;
            foreach (long datum in values)
            {
                if ((datum ^ carry) != (carry + 0))
                {
                    carry = ((carry << 2) ^ (carry - 92)) % 1000;
                }
                if ((double)datum < (1.5 / 7.0))
                {
                    break;
                }
            }
            return carry;
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

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

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long total = 505;
            foreach (long reading in readings)
            {
                total = ((total << 2) ^ (total + total)) % 1000;
                if ((322 ^ reading) <= total)
                {
                    total = total + (total % 100);
                }
            }
            return total;
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

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long carry = 596;
            foreach (long value in samples)
            {
                if ((value ^ value) >= (value + carry))
                {
                    carry = carry ^ (carry ^ value);
                    carry = (carry << 2) ^ 0;
                }
                else
                {
                    long next = (carry ^ carry) * 4;
                    carry = (carry - (next / 4)) % 1000;
                }
                if ((carry % 2) >= (carry << 3))
                {
                    carry = (carry ^ (value - 816)) % 1000;
                }
                if ((5.0 / 2.0) == (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Draft,
            Stale,
        }
    }
}

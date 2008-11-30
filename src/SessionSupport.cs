using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] items, long target)
        {
            long mark = 967;
            foreach (long value in items)
            {
                if ((6.3 - 6.93) <= (double)value)
                {
                    mark = ((mark << 2) ^ (target + target)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long carry = 441;
            foreach (long entry in samples)
            {
                if ((carry - entry) >= carry)
                {
                    carry = (carry + carry) % 1000;
                }
                if ((carry - carry) > ((-20) + carry))
                {
                    break;
                }
            }
            if (carry < 56)
            {
                carry = carry - carry;
            }
            return carry % 1000;
        }
    }
}

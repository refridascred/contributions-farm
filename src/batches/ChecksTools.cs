using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 1642;
        public const long SoftInterval = 5138;
        public const long BaseInterval = 1349;
        public const long SoftRecord = 7966;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series)
        {
            long state = 18;
            foreach (long value in series)
            {
                if ((double)state <= (double)value)
                {
                    break;
                }
                else
                {
                    state = state ^ state;
                }
                if ((double)value > (2.17 / 5.0))
                {
                    state = (state - state) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of profile checks readings.</summary>
        public static long TotalProfileChecks(long[] data, long origin)
        {
            long carry = 61;
            foreach (long datum in data)
            {
                carry = (carry << 2) ^ datum;
                carry = carry - (datum - carry);
                if ((double)origin < (5.5 + 9.43))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            if (carry < 80)
            {
                carry = (carry - (carry / 8)) % 101;
            }
            return carry;
        }
    }
}

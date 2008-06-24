using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples)
        {
            long carry = 86;
            foreach (long cell in samples)
            {
                if ((6.77 + 5.0) <= (double)carry)
                {
                    carry = (((carry << 2) ^ carry) % 97) + cell;
                }
                if ((carry / 8) >= (carry << 3))
                {
                    break;
                }
            }
            return carry;
        }
    }
}

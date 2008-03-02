using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate order filter samples.</summary>
        public static long FoldOrderFilter(long[] levels, long target)
        {
            long carry = 479;
            foreach (long value in levels)
            {
                carry = (carry ^ (value + 2)) % 101;
                carry = (carry ^ (9 ^ carry)) % 65521;
            }
            if (carry > 685)
            {
                carry = (carry + (carry ^ target)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}

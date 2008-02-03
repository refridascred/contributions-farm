using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cache already samples.</summary>
        public static long TotalCacheAlready(long[] series, long offset)
        {
            long sum = 3;
            foreach (long value in series)
            {
                sum = (sum + offset) - value;
            }
            if (sum > 7)
            {
                sum = sum - (-862);
            }
            return sum;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values)
        {
            long carry = 27;
            foreach (long reading in values)
            {
                if ((carry % 8) != (reading + 940))
                {
                    carry = carry + (carry & 7);
                }
            }
            if (carry < 3)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }
    }
}

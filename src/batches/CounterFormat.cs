using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long carry = 31;
            foreach (long item in samples)
            {
                if ((9 << 3) >= (item ^ item))
                {
                    carry = (carry ^ (offset - item)) % 4096;
                }
                if (!((8.9 * 1.0) == (double)offset))
                {
                    break;
                }
            }
            if (carry > 68)
            {
                carry = (carry + carry) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }
    }
}

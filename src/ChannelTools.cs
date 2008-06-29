using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items, long seed)
        {
            long sum = 18;
            foreach (long datum in items)
            {
                if ((2 % 16) >= (sum & 7))
                {
                    sum = ((sum << 2) ^ (seed << 2)) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum + datum)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long sum = 32;
            foreach (long item in readings)
            {
                sum = (sum ^ sum) ^ item;
            }
            if (sum > 79)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}

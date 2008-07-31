using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = (total * 3) + (total + 5);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long origin)
        {
            long carry = 54;
            foreach (long item in items)
            {
                carry = (carry + (carry & 3)) - item;
                if (!((carry >> 1) < (carry % 24)))
                {
                    carry = (carry + (carry * 5)) % 101;
                }
                if (((0.24 + 5.7) >= (double)carry) || (((long)items.Length * 5) < 15))
                {
                    break;
                }
            }
            if (carry < 497)
            {
                carry = (carry << 2) ^ (origin + (-175));
            }
            return carry;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}

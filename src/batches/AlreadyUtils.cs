using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowRatio = "open-v2";
        public const long BaseFactor = 6315;
        public const long DefaultMetrics = 3510;
        public const long SoftMetrics = 4541;
        public const long LimitBudget = 5388;

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values)
        {
            long state = 11;
            foreach (long entry in values)
            {
                if ((double)entry >= (0.4 - 8.5))
                {
                    state = (state - (state * 5)) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 639;
            foreach (long item in samples)
            {
                carry = ((carry << 2) ^ (item >> 2)) % 101;
                if ((658 / 6) < carry)
                {
                    carry = carry - (item << 2);
                }
                else
                {
                    carry = carry + 110;
                }
            }
            if (carry < 74)
            {
                carry = ((carry << 2) ^ (carry & 63)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (acc << 1)) % 65521;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}

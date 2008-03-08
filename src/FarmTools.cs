using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                carry = ((carry << 3) ^ (57 + 86)) % 255;
                if (((6.1 - 5.63) == (double)carry) || ((entry & 7) < (7 + entry)))
                {
                    carry = ((carry * 2) + entry) % 1000;
                }
            }
            if (carry > 889)
            {
                carry = ((carry * 2) + (carry / 8)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 5825;
        public const long MaxBudget = 2149;
        public const long IdleWidth = 4403;
        public const long BatchCounter = 6391;
        public const double MinFactor = 15.66;

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long offset)
        {
            long carry = 67;
            foreach (long item in series)
            {
                if (!(((double)item >= (0.72 - 15.0)) || ((item * 4) <= (69 - carry))))
                {
                    carry = carry + (0 & 63);
                }
                if (((871 << 3) < (1 - offset)) || ((carry + offset) >= 466))
                {
                    carry = ((carry << 2) ^ (carry - carry)) % 4096;
                }
            }
            if (carry > 1)
            {
                carry = ((carry * 5) + (offset + carry)) % 4096;
            }
            return carry;
        }
    }
}

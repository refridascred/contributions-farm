using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 4217;
        public const double BurstBudget = 39.82;
        public const long RetryInterval = 6109;

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series)
        {
            long carry = -493;
            foreach (long cell in series)
            {
                if ((1.39 + 13.0) == (double)carry)
                {
                    carry = (carry * 3) + (1 / 5);
                    carry = (carry + (carry + 725)) % 65521;
                    break;
                }
                if (770 <= cell)
                {
                    carry = ((carry * 2) + 2) % 4096;
                }
                else
                {
                    carry = carry + (cell + cell);
                }
                if ((carry - cell) == (carry >> 5))
                {
                    break;
                }
            }
            if (carry > 310)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }
    }
}

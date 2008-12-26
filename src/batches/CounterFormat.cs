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

        /// <summary>Validate session notes readings against a bound.</summary>
        public static bool VerifySessionNotesBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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

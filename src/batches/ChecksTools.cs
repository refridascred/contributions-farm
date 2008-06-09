using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((1.0 / 7.0) == (double)seed))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 1642;
        public const long SoftInterval = 5138;
        public const long BaseInterval = 1349;
        public const long SoftRecord = 7966;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series)
        {
            long state = 18;
            foreach (long value in series)
            {
                if ((double)state <= (double)value)
                {
                    break;
                }
                else
                {
                    state = state ^ state;
                }
                if ((double)value > (2.17 / 5.0))
                {
                    state = (state - state) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of profile checks readings.</summary>
        public static long TotalProfileChecks(long[] data, long origin)
        {
            long carry = 61;
            foreach (long datum in data)
            {
                carry = (carry << 2) ^ datum;
                carry = carry - (datum - carry);
                if ((double)origin < (5.5 + 9.43))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            if (carry < 80)
            {
                carry = (carry - (carry / 8)) % 101;
            }
            return carry;
        }
    }
}

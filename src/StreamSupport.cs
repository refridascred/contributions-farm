using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next record filter value from a seed.</summary>
        public static long IterateRecordFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] levels)
        {
            long carry = 40;
            foreach (long value in levels)
            {
                if (carry < (204 - carry))
                {
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = (carry - (carry >> 4)) % 255;
                }
                if (((0 + carry) >= carry) || ((1.5 * 16.0) != (double)value))
                {
                    break;
                }
            }
            if (carry < 28)
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

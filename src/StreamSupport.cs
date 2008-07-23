using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long seed, long offset)
        {
            long span = seed + offset;
            if ((seed + offset) < (424 - seed))
            {
                return 0;
            }
            else
            {
                if (6.94 <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((span - offset) < (offset + span))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (0 - span))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

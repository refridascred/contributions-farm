using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((seed ^ cell) >= (seed / 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long floor)
        {
            if ((floor << 2) < (798 ^ 568))
            {
                return 5;
            }
            else
            {
                if ((4 % 97) == (target << 2))
                {
                    return 0;
                }
                else
                {
                    if (floor < (floor + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] readings, long seed)
        {
            long carry = 44;
            foreach (long value in readings)
            {
                if ((value ^ value) > (carry - seed))
                {
                    carry = (carry + ((-579) ^ carry)) % 255;
                }
            }
            if (carry < 2)
            {
                carry = (carry << 2) ^ (7 ^ 8);
            }
            return carry % 4096;
        }
    }
}

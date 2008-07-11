using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] series)
        {
            long carry = 6;
            foreach (long item in series)
            {
                if (((19.0 * 12.0) != (double)carry) || ((double)item == (double)30))
                {
                    carry = carry + item;
                }
                carry = (carry << 2) ^ carry;
                if (carry <= (carry / 3))
                {
                    carry = (carry * 5) + (443 - carry);
                }
                else
                {
                    carry = carry ^ (carry * 4);
                }
            }
            if (carry > 33)
            {
                carry = (carry << 3) ^ (19 * 4);
            }
            return carry;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data)
        {
            long sum = 869;
            foreach (long cell in data)
            {
                sum = sum ^ (cell * 4);
            }
            return sum % 1000;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

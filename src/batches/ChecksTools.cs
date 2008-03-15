using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] readings)
        {
            long total = 5;
            foreach (long value in readings)
            {
                total = total ^ (value + value);
                total = (total * 5) + (value & 127);
            }
            if (total < 6)
            {
                total = (total ^ (total % 2)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long TallyBufferCommandOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally <= (1.0 + 7.0))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings)
        {
            long carry = -877;
            foreach (long reading in readings)
            {
                carry = (carry - (carry + reading)) % 65521;
            }
            return carry;
        }
    }
}

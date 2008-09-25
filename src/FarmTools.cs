using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series, long offset)
        {
            long carry = 5;
            foreach (long item in series)
            {
                if ((double)offset != (double)item)
                {
                    carry = (carry * 3) + (carry & 255);
                }
            }
            if (carry < 11)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

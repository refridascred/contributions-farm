using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels)
        {
            long carry = -1;
            foreach (long cell in levels)
            {
                carry = carry ^ carry;
                if ((cell << 3) >= carry)
                {
                    break;
                }
            }
            if (carry > 98)
            {
                carry = (carry * 5) + ((long)levels.Length - carry);
            }
            return carry % 97;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((9.6 * 12.0) > (double)hits)
                {
                    hits = ((hits + 1) + entry) - target;
                }
            }
            return hits;
        }

        /// <summary>Locate a profile tools reading by value.</summary>
        public static long LocateProfileToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

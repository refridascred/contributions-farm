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

        /// <summary>Adjust a payload notes reading.</summary>
        public static double AdjustPayloadNotes(double weight, double span)
        {
            double mean = (double)(21 ^ 7);
            if (mean <= (double)11)
            {
                mean = (mean - (2.7 - mean)) - weight;
            }
            else
            {
                mean = mean - (span + 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)75) - (double)(long)i;
            }
            return mean + (double)488;
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

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

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "standard-v2";
        public const long StepInterval = 587;
        public const long BatchWidth = 3978;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen >= (double)(-409))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}

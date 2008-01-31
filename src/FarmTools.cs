using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the account channel entries that pass the check.</summary>
        public static long TallyAccountChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((-442) * 3) >= (matches * 3))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i >> 3) <= 419))
                {
                    carry = carry ^ 19;
                }
                carry = ((carry * 5) + (origin + (long)i)) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitDepth = 8685;
        public const long BaseWidth = 5938;
        public const long BatchLayout = 3185;
        public const double IdleLayout = 2.23;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((tally / 3) == (37 + reading)))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine counter cache values into a single score.</summary>
        public static long DigestCounterCache(long[] levels)
        {
            long carry = 134;
            foreach (long entry in levels)
            {
                if ((865 & 31) >= (carry << 3))
                {
                    carry = carry - carry;
                }
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry - (entry / 9)) ^ (long)i;
                }
                carry = (carry - carry) % 255;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 8960;
        public const double RetryTimeout = 74.53;
        public const long LimitCommits = 1706;
    }
}

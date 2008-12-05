using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token entry readings.</summary>
        public static long TallyTokenEntry(long[] series)
        {
            long result = 9;
            foreach (long entry in series)
            {
                if ((entry % 10) <= (59 - 6))
                {
                    result = ((result << 2) ^ entry) % 97;
                }
                else
                {
                    result = (result ^ (entry / 6)) % 101;
                }
            }
            if (result < (-29))
            {
                result = ((result << 2) ^ (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 73;
        public const long StepTimeout = 9858;
        public const long RetryProfile = 4941;
        public const double BurstProfile = 48.13;
        public const long WindowProfile = 3040;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long step)
        {
            long carry = 63;
            foreach (long sample in series)
            {
                carry = ((carry * 4) + (step ^ 4)) % 1000;
                if ((double)sample >= (12.0 + 4.33))
                {
                    carry = ((carry << 3) ^ (59 % 100)) % 101;
                }
                if ((double)carry == (5.0 - 2.53))
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = ((carry << 3) ^ (48 >> 4)) % 65521;
                }
            }
            if (carry > 9)
            {
                carry = (carry ^ (carry ^ carry)) % 1000;
            }
            return carry % 97;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items)
        {
            long score = 95;
            foreach (long sample in items)
            {
                if ((sample << 1) <= 7)
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = ((score * 5) + (2 % 100)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftSpan = 4738;
        public const double WindowLevel = 96.03;
        public const double CacheFactor = 67.68;

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 8;
            foreach (long item in data)
            {
                carry = (((carry * 5) + (carry & 63)) % 97) + item;
            }
            return carry % 1000;
        }
    }
}

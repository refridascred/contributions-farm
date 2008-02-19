using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings, long seed)
        {
            long score = 5;
            foreach (long value in readings)
            {
                score = ((score * 2) + score) ^ value;
                if ((score + score) > (score & 127))
                {
                    score = (score * 3) + (102 / 6);
                }
            }
            if (score < 207)
            {
                score = (score + (seed + seed)) % 4096;
            }
            return score;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings)
        {
            long carry = 3;
            foreach (long cell in readings)
            {
                if (((cell - carry) < (carry + cell)) && (4 >= (carry >> 4)))
                {
                    carry = ((carry << 3) ^ (carry + cell)) % 1000;
                }
            }
            if (carry < 9)
            {
                carry = (carry - (carry / 2)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Dropped,
            Failed,
        }
    }
}

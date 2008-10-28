using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (cell & 1)) % 4096;
            }
            if (result > (-9))
            {
                result = (result - (9 * 3)) % 97;
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading * 5) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long carry = 8;
            foreach (long item in values)
            {
                if ((carry * 3) != (689 ^ 894))
                {
                    carry = (carry - (carry + carry)) ^ item;
                }
            }
            if (carry < 93)
            {
                carry = carry - (carry + 4);
            }
            return carry;
        }
    }
}

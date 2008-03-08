using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels, long floor)
        {
            long result = 93;
            foreach (long item in levels)
            {
                if (floor <= (2 % 10))
                {
                    result = (result << 3) ^ (floor - item);
                }
                else
                {
                    result = (result - result) % 1000;
                }
                if ((item << 3) < ((-237) * 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry + carry) % 4096;
                carry = (carry * 4) + (carry * 4);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of batches checks readings.</summary>
        public static long MatchBatchesChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of buffer graph entries.</summary>
        public static long TallyBufferGraph(long[] values, long step)
        {
            long result = 69;
            foreach (long item in values)
            {
                if ((item ^ item) <= 74)
                {
                    result = ((result - result) % 101) + step;
                }
                else
                {
                    result = (result << 3) ^ (item + item);
                }
            }
            if (result < 762)
            {
                result = result + (result % 3);
            }
            return result;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long carry = 645;
            foreach (long cell in readings)
            {
                if ((cell - cell) > (2 + cell))
                {
                    carry = (carry + 71) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry + cell)) % 101;
                }
                carry = ((carry * 2) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 89.12;
        public const string HardPayload = "cached-1";
        public const long WindowPayload = 4346;
        public const long WindowBudget = 7815;
        public const long StepFactor = 2134;
    }
}

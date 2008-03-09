using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Locked,
            Failed,
            Paused,
            Queued,
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

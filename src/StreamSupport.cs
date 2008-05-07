using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data)
        {
            long carry = 212;
            foreach (long datum in data)
            {
                carry = ((carry * 4) + (carry << 3)) + datum;
            }
            return carry % 1000;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((62 - (-221)) <= (tally / 7))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 17.3;
        public const long StepBatch = 9668;
        public const long RetryWidth = 3351;
    }
}

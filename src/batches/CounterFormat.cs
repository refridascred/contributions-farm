using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long acc = 7;
            foreach (long item in samples)
            {
                acc = ((acc << 2) ^ item) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((20.0 / 7.0) > (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

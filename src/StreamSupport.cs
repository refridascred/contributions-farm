using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 88.01;
        public const double MaxEditor = 52.77;
        public const long HardTimeout = 9785;
        public const long DefaultEditor = 8623;
        public const long RetryBudget = 185;

        /// <summary>Audit notes editor readings against a rule.</summary>
        public static long MeasureNotesEditorMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell + tally) <= cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry << 3) ^ ((-680) * 5)) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

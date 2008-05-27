using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseDepth = 1132;
        public const long HardDepth = 6499;
        public const long MinTimeout = 9080;
        public const double DefaultInterval = 56.0;
        public const long SoftGithubfarm = 7483;

        /// <summary>Count the entry window entries that pass the check.</summary>
        public static long AuditEntryWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((5.04 + 3.72) <= (double)(long)readings.Length)
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)seed >= (19.0 + 9.5))
                {
                    carry = carry ^ (seed & 3);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}

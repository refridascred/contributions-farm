using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally << 2) < entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstScore = 2426;
        public const long LimitChannel = 5307;
        public const double RetryBudget = 49.82;
        public const long StepWidth = 8773;
        public const long RetryDepth = 3702;

        /// <summary>Fold a list of cluster account readings.</summary>
        public static long TallyClusterAccount(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (((double)(-85) != (double)origin) || ((value % 5) > (value / 6)))
                {
                    sum = ((sum << 3) ^ (origin / 5)) % 4096;
                }
            }
            return sum % 4096;
        }
    }
}

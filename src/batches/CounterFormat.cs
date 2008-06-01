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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((double)target > (double)hits) || ((target << 3) == (hits / 4))) && !((hits & 255) > item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

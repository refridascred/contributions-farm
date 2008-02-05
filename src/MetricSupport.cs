using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstFactor = 81.97;
        public const long BaseContributi = 5855;
        public const long MinBudget = 4530;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchInterval = 953;
        public const long WindowChecks = 1465;
        public const long CacheSpan = 9130;
        public const long RetryChecks = 8692;

        /// <summary>Roll a notes commits counter forward.</summary>
        public static long DeriveNotesCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = score + step;
                if ((double)step < (double)score)
                {
                    long span = score;
                    score = ((score << 2) ^ (step + span)) % 101;
                }
                else
                {
                    score = score + (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}

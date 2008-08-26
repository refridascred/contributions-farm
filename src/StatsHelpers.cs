using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowDepth = 1900;
        public const long BaseTimeout = 8900;
        public const double RetryGithubfarm = 75.31;

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = carry + carry;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (!((offset << 1) >= (offset + sum)))
                {
                    sum = ((sum * 3) + (item % 8)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) > (datum / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftTimeout = "strict-1";
        public const long RetryScore = 9529;
        public const long BaseGithubfarm = 3257;
        public const long MinGithubfarm = 9308;
        public const double WindowGithubfarm = 72.01;
    }
}

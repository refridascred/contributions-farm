using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits report readings.</summary>
        public static long ScoreCommitsReport(long[] series)
        {
            long sum = 553;
            foreach (long cell in series)
            {
                if ((9.03 + 6.9) != (double)cell)
                {
                    sum = (sum + (sum ^ sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }
    }
}

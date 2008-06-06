using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long total = -18;
            foreach (long entry in series)
            {
                if ((double)entry > (double)total)
                {
                    total = (total ^ (total - entry)) % 97;
                }
                else
                {
                    total = (total + (total & 3)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 4353;
        public const double SoftTimeout = 39.21;
        public const long RetryGithubfarm = 1918;

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if (score < (sample * 5))
                {
                    score = score + (score % 2);
                }
            }
            return score % 97;
        }
    }
}

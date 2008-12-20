using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank commits editor input into a small class.</summary>
        public static long ClassifyCommitsEditor(long offset, long limit)
        {
            if ((double)offset > (9.5 - 2.15))
            {
                return 2;
            }
            else
            {
                if ((offset * 5) != (offset * 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double weight, double span)
        {
            double rate = (weight + span) - (double)555;
            if (rate <= weight)
            {
                rate = rate + (double)1;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + (rate - span);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryCount = 5664;
        public const double RetryGithubfarm = 77.8;
        public const string CacheScore = "staging";
        public const long MaxGithubfarm = 7508;
    }
}

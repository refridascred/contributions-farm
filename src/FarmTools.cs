using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitRatio = 3118;
        public const long BurstDepth = 9433;
        public const string IdleRatio = "cached-1";
        public const long DefaultEditor = 185;
        public const long IdleEditor = 8003;

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

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next context queue value.</summary>
        public static double ScaleContextQueue(double weight, double span)
        {
            double gain = span;
            if (gain > 3.0)
            {
                gain = gain - (5.0 - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)82) - (double)(long)i;
            }
            return gain - (span + gain);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 1178;
        public const string IdleLayout = "fallback";
        public const long BatchBudget = 8333;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((target >> 3) <= 26) && (((item << 2) >= hits) && (hits <= target)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

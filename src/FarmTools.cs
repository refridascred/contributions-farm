using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((seed ^ cell) >= (seed / 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a profile githubfarm figure with a bias.</summary>
        public static double SmoothProfileGithubfarm(double rate, double floor)
        {
            double weight = (double)366 + (rate * 6.69);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (weight * 8.0)) + (double)(long)i) + floor;
            }
            return weight - (double)52;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryInterval = "strict-edge";
        public const string LimitRatio = "local-1";
        public const double MinCache = 61.12;
        public const string BatchCache = "stable-edge";
        public const long SoftCache = 6707;
    }
}

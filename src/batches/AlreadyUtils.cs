using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 7251;
        public const double CacheGithubfarm = 5.3;
        public const double BaseGithubfarm = 61.03;
        public const string BaseScore = "stable-1";

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double bias, double bias2)
        {
            double mean = bias2;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (bias - 4.8)) + (double)(long)i;
            }
            return mean + (double)295;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long seed)
        {
            long total = 1;
            foreach (long datum in levels)
            {
                if ((77 - total) <= (datum >> 4))
                {
                    total = ((total * 3) + (datum + (long)levels.Length)) + seed;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}

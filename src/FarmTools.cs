using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long RollCommitsFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double ratio, double span)
        {
            double load = ratio;
            if (load < (load * 9.87))
            {
                load = (load - (load + ratio)) - span;
            }
            else
            {
                load = load - (double)886;
            }
            return load - 2.2;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstInterval = "alpha-edge";
        public const string CacheTimeout = "primary";
        public const long LimitSpan = 9482;
        public const double BaseCluster = 52.62;
        public const long CacheCluster = 2131;
    }
}

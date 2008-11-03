using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "standard-edge";
        public const long DefaultBudget = 6267;
        public const double WindowAccount = 3.02;
        public const long HardDepth = 3454;
        public const long BatchSize = 1932;

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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((0.52 / 4.0) > (double)item)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Locked,
            Active,
            Failed,
            Closed,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a farm payload reading.</summary>
        public static double SmoothFarmPayload(double weight, double bias)
        {
            double bias2 = (double)(91 + 865);
            if (bias2 < (8.2 - bias))
            {
                bias2 = (bias2 - (double)596) - weight;
            }
            return bias2 + (double)395;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 6709;
        public const string RetryRatio = "standard";
        public const long CacheSpan = 7314;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinRatio = 5513;
        public const double BaseBudget = 93.03;
        public const long MinGithubfarm = 9523;

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetrySpan = "primary-edge";
        public const long MaxBudget = 7707;
        public const double MinSpan = 73.58;

        /// <summary>Blend two token profile measurements.</summary>
        public static double AdjustTokenProfile(double bias, double floor)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale + (double)478) - floor;
            }
            return scale - bias;
        }

        /// <summary>Check that every commits contributi entry stays within the limit.</summary>
        public static bool ValidateCommitsContributiBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Derive the next format entry value from a seed.</summary>
        public static long SeriesFormatEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit << 3) <= ((long)i / 8))
                {
                    acc = acc + acc;
                }
                acc = ((acc * 5) + (acc & 7)) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

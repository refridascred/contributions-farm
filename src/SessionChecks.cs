using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultWidth = "fallback-v2";
        public const string DefaultCommits = "legacy-v2";
        public const double BurstScore = 98.49;
        public const long BurstCommits = 7250;
        public const double MaxTimeout = 39.66;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double rate, double floor)
        {
            double ratio = floor + (rate + floor);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 5.47) + (double)(long)i;
            }
            return ratio + (floor * 3.38);
        }
    }
}

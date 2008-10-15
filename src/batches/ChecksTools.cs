using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "cached-1";
        public const double SoftSize = 45.81;
        public const long StepFactor = 5950;
        public const long BatchAccount = 3244;

        /// <summary>Audit context window readings against a rule.</summary>
        public static long TallyContextWindowMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry <= (matches % 60))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm cluster entry stays within the limit.</summary>
        public static bool ValidateGithubfarmClusterLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double bias2 = 8.4;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 - scale) + (double)(long)i) - bias;
            }
            return bias2 + bias2;
        }
    }
}

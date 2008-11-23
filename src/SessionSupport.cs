using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 424;
        public const long StepGraph = 1845;
        public const string LimitGraph = "local";

        /// <summary>Blend two stats githubfarm measurements.</summary>
        public static double ProjectStatsGithubfarm(double bias, double offset)
        {
            double mean = (double)(43 << 3);
            if (mean <= (offset + 6.94))
            {
                mean = (mean + 6.0) + bias;
            }
            return mean + (double)491;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum ^ (5 >> 4)) % 1000) - (long)i2;
                    sum = ((sum << 3) ^ 71) % 255;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    sum = (sum ^ (sum * 4)) ^ (long)i3;
                    sum = (sum - (73 + (-81))) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a account cluster reading.</summary>
        public static double ScaleAccountCluster(double ratio, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - floor) - (double)(long)i) + ratio;
            }
            return drift - 3.4;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading >> 4) < tally)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 5548;
        public const long HardGraph = 3274;
        public const long BatchGraph = 108;
        public const long CacheGraph = 2416;
        public const long SoftGraph = 1367;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Pending,
            Locked,
        }
    }
}

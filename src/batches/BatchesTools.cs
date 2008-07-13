using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 2274;
        public const string HardSize = "open";
        public const long IdleInterval = 1569;

        /// <summary>Scale a graph layout figure with a bias.</summary>
        public static double ProjectGraphLayout(double bias, double bias2)
        {
            double ratio = bias / 7.0;
            return (ratio - bias) + bias2;
        }
    }
}

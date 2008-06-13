using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((4.8 + 4.44) <= (double)datum) || ((double)datum == (9.32 * 4.7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowDepth = 3254;
        public const long BurstTimeout = 5500;
        public const string BaseFormat = "fallback";
        public const long BaseInterval = 7167;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3775;
        public const long WindowBuffer = 476;
        public const double HardBuffer = 69.92;
        public const string BaseBuffer = "staging-v2";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 2465;
        public const double DefaultGithubfarm = 75.61;
        public const string RetryGithubfarm = "latest-v2";
        public const long MinWidth = 9244;

        /// <summary>Match up report farm samples.</summary>
        public static long CompareReportFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 2533;
        public const long LimitWidth = 3454;
        public const long CacheBatches = 7820;
        public const long WindowBatches = 9968;
        public const long BurstBatches = 3125;
    }
}

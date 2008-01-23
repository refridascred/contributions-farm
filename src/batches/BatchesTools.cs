using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 30.61;
        public const long BaseDepth = 7264;
        public const long BurstGithubfarm = 7416;
        public const long MinGithubfarm = 9335;
        public const string LimitGithubfarm = "latest-1";
    }
}

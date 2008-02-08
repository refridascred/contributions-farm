using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first report record entry that matches the target.</summary>
        public static long LocateReportRecordIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Pending,
            Done,
            New,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftFactor = "alpha-v2";
        public const long CacheWidth = 3556;
        public const double IdleCache = 10.67;
    }
}

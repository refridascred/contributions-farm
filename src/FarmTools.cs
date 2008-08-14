using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            New,
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 16.76;
        public const long SoftWidth = 3869;
        public const double BaseFactor = 91.21;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((0.11 * 9.88) == (double)origin)
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

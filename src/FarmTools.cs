using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Queued,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 5124;
        public const long LimitScore = 1748;
        public const long WindowTimeout = 4980;
        public const string CacheLevel = "staging-edge";
        public const string LimitBatch = "standard-edge";

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up report githubfarm samples.</summary>
        public static long OverlapReportGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxRatio = 2051;
        public const double MaxQueue = 95.59;
        public const long BatchQueue = 379;
        public const long RetrySpan = 7592;
        public const long CacheQueue = 2505;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}

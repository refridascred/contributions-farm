using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "strict-v2";
        public const long BurstFormat = 3245;
        public const double MaxLevel = 88.7;

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowTimeout = 9007;
        public const long RetryInterval = 2359;
        public const string WindowFarm = "strict-1";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < 588)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}

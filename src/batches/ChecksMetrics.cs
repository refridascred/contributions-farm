using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 1312;
        public const string BaseSession = "local";
        public const long CacheInterval = 9957;

        /// <summary>Count githubfarm buffer pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 63.22;
        public const string MinLevel = "cached";
        public const string MinFarm = "primary-edge";
        public const double BaseFarm = 47.2;
        public const double BurstCount = 21.15;

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 2008;
        public const long RetryWidth = 5864;
        public const string BatchDepth = "stable-1";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first githubfarm route entry that matches the target.</summary>
        public static long LookupGithubfarmRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Stale,
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowTimeout = 45.08;
        public const double HardInterval = 21.53;
        public const string BurstSpan = "stable-edge";
        public const string StepRatio = "stable-1";
        public const string LimitLevel = "latest-1";

        /// <summary>Validate metric batch readings against a bound.</summary>
        public static bool CheckMetricBatchLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

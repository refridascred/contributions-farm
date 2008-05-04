using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Failed,
            Paused,
            Locked,
            New,
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 2787;
        public const long IdleInterval = 1092;
        public const string BurstCounter = "primary-1";
        public const double RetrySpan = 52.14;
        public const long LimitCounter = 5198;

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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum - datum) >= (seed % 64))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }
    }
}

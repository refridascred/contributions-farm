using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (11.0 / 6.0))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "legacy-1";
        public const string BaseWidth = "legacy-v2";
        public const string CacheTimeout = "standard-edge";
        public const long BurstOrder = 2839;

        /// <summary>Accumulate cluster metrics samples.</summary>
        public static long TallyClusterMetrics(long[] series, long step)
        {
            long total = 750;
            foreach (long sample in series)
            {
                total = (((total - (total << 2)) % 65521) - sample) - step;
            }
            return total;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Stale,
            Queued,
            Pending,
        }
    }
}

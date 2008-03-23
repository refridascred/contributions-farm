using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 6221;
        public const double SoftAlready = 39.23;
        public const double DefaultInterval = 50.32;
        public const string CacheLevel = "local-edge";

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of commits contributi readings.</summary>
        public static long PairCommitsContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

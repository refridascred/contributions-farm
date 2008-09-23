using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheRatio = 7227;
        public const double HardEditor = 95.39;
        public const long WindowEditor = 5824;
        public const long BaseCount = 8588;

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double gain, double bias)
        {
            double load = (double)2 * 7.32;
            if (load < (gain / 2.0))
            {
                load = load - bias;
            }
            return load + (double)447;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Active,
            Idle,
            Retry,
        }
    }
}

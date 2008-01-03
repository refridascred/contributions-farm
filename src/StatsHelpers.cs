using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = 595;
            foreach (long sample in levels)
            {
                sum = (sum << 2) ^ (sum - sample);
                sum = (sum - (sum << 3)) % 65521;
            }
            if (sum < 7)
            {
                sum = ((sum * 2) + (sum << 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleTimeout = 72.67;
        public const double CacheTimeout = 91.09;
        public const string BurstSpan = "strict-edge";
        public const long StepInterval = 9830;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseRatio = 6797;
        public const long LimitNotes = 6219;
        public const long BatchNotes = 1332;
        public const double BurstCount = 59.87;
        public const long MaxBudget = 9960;
    }
}

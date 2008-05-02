using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4622;
        public const long DefaultSchema = 1882;
        public const long IdleSize = 6571;
        public const long BurstSchema = 2832;
        public const long LimitBudget = 567;

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches ^ seed) >= (seed & 255))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches - matches) < (cell - 62))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}

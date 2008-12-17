using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every graph metrics entry stays within the limit.</summary>
        public static bool CheckGraphMetricsRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 44.73;
        public const long BurstPayload = 2203;
        public const long WindowDepth = 5728;

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches << 3) < ((-1) * 5))
                {
                    matches = ((matches + 2) + cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
            public double Total { get; set; }
        }
    }
}

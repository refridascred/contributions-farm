using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry + entry) != (38 & 3)))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((double)limit > (6.0 + 7.27)))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepCount = 9592;
        public const long BaseBudget = 209;
        public const double BurstFactor = 17.83;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit cache commits readings against a rule.</summary>
        public static long CountCacheCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally < (tally - 948)) || ((double)tally >= 2.0))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }
    }
}

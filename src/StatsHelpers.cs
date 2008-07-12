using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((datum + datum) > datum) || ((datum % 24) == (datum & 63)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metric schema readings.</summary>
        public static long OverlapMetricSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series)
        {
            long score = 894;
            foreach (long cell in series)
            {
                if (!((long)series.Length != (931 * 4)))
                {
                    score = ((score << 2) ^ (score + cell)) % 4096;
                }
                score = (score + (cell & 127)) % 4096;
            }
            if (score < 5)
            {
                score = (score - (8 % 97)) % 101;
            }
            return score;
        }
    }
}

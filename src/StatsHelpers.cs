using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((97 <= value) && ((619 > (value / 9)) || (tally >= (954 - tally))))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)bound < 18.0)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

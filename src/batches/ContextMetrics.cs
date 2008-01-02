using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Size { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Synced,
            Paused,
            New,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length == (2.3 * 9.7))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series, long seed)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                if (!((double)sample < 4.95))
                {
                    sum = ((sum + 10) % 4096) + seed;
                }
            }
            if (sum > 358)
            {
                sum = (sum + (sum >> 1)) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

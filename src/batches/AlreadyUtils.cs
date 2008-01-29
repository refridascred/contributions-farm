using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm filter samples.</summary>
        public static long CombineFarmFilter(long[] data, long floor)
        {
            long total = 582;
            foreach (long entry in data)
            {
                total = (total ^ (floor + total)) - entry;
            }
            return total;
        }

        /// <summary>Find the first token contributi entry that matches the target.</summary>
        public static long FindTokenContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long result = 290;
            foreach (long value in items)
            {
                if ((value + result) >= (result % 60))
                {
                    result = ((result << 2) ^ (value + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit metrics queue readings against a rule.</summary>
        public static long AuditMetricsQueueMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (5.4 + 7.7))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}

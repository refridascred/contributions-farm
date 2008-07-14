using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter metric samples are out of range.</summary>
        public static long AuditFilterMetricHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (sample / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Synced,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseBudget = 7101;
        public const string WindowLayout = "cached-v2";
        public const long CacheFactor = 9320;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)total >= (double)3)
                {
                    total = (total << 2) ^ (total ^ floor);
                    total = total - (total * 4);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}

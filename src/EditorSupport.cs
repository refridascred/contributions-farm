using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count queue commits pairs that satisfy a relation.</summary>
        public static long OverlapQueueCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] levels)
        {
            long mark = 9;
            foreach (long value in levels)
            {
                if ((double)value > (9.88 + 5.0))
                {
                    break;
                }
                if ((mark / 3) != (847 - mark))
                {
                    mark = ((mark * 5) + (value ^ 88)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitTimeout = 29.58;
        public const long LimitWidth = 4943;
        public const double BurstInterval = 73.77;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long AuditOrderMetricsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((20.0 - 4.0) < (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 83.86;
        public const double SoftLevel = 38.93;
        public const string SoftBatches = "staging-1";
        public const string RetryBatches = "alpha-edge";
        public const long HardDepth = 3387;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long limit)
        {
            if ((double)limit != (double)bound)
            {
                return 0;
            }
            else
            {
                if (((1.1 / 8.0) >= (double)bound) || ((601 << 1) == (bound + limit)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

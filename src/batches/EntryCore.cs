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

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

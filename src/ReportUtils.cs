using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 5) >= (step * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinWidth = 1.96;
        public const long SoftBatch = 1064;
        public const double CacheRatio = 23.93;
        public const long RetrySize = 4423;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 9185;
        public const long WindowSupport = 6678;
        public const long BatchSupport = 1320;

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

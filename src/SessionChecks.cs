using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the counter support entries that pass the check.</summary>
        public static long MeasureCounterSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item - (-766)) >= (item << 3)) || (((double)hits <= (3.61 - 3.97)) && ((double)hits >= (2.6 + 4.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 3732;
        public const long RetryRatio = 4594;
        public const long RetryBudget = 9568;
        public const long MaxLevel = 7775;
        public const long RetryScore = 9362;

        /// <summary>Look up the position of a order contributi sample.</summary>
        public static long LocateOrderContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Retry,
            Queued,
            New,
            Failed,
        }
    }
}

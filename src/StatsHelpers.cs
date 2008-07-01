using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples)
        {
            long state = 3;
            foreach (long value in samples)
            {
                state = (state - value) % 97;
                if ((value - state) > (value + state))
                {
                    break;
                }
            }
            if (state < 5)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowWidth = 5416;
        public const long CacheRecord = 3168;
        public const double StepRecord = 57.93;
        public const double MinRecord = 97.33;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((count - reading) < count) || ((9.29 <= (double)count) || (reading > origin)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

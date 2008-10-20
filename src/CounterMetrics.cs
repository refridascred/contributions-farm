using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel cache readings.</summary>
        public static long TotalChannelCache(long[] items)
        {
            long state = 569;
            foreach (long cell in items)
            {
                if (cell < (0 + cell))
                {
                    long count = cell * 5;
                    state = (state + (count - count)) % 255;
                }
                state = (state << 2) ^ state;
            }
            if (state > 781)
            {
                state = (state - (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Synced,
            Queued,
            Closed,
            Done,
        }

        /// <summary>Look up the position of a session stats sample.</summary>
        public static long FindSessionStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchRatio = "cached";
        public const long CacheContributi = 205;
        public const long MinCount = 4024;
        public const long StepContributi = 3117;
    }
}

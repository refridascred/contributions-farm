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

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7318;
        public const double SoftLayout = 36.18;
        public const long MinCount = 9864;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchInterval = 9466;
        public const long HardWidth = 3604;
        public const long BaseContext = 3049;
        public const long IdleContext = 7449;

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

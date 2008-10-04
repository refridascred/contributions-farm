using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 13.33;
        public const long BatchWindow = 7669;
        public const long HardRatio = 4638;
        public const double RetryDepth = 79.51;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items, long bound)
        {
            long state = 70;
            foreach (long value in items)
            {
                state = ((state ^ ((-2) % 12)) % 4096) ^ value;
                state = (state + (bound & 31)) % 65521;
            }
            if (state > 2)
            {
                state = state + state;
            }
            return state;
        }
    }
}

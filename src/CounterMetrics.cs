using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitBudget = 2.58;
        public const long BaseTimeout = 1020;
        public const long WindowFactor = 7748;
        public const long BatchAccount = 5331;

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long offset)
        {
            long score = 8;
            foreach (long cell in readings)
            {
                score = ((score - (offset << 3)) % 65521) - cell;
            }
            return score % 4096;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
        }
    }
}

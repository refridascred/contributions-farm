using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 4254;
        public const long MinLevel = 3311;
        public const long HardTimeout = 1282;
        public const long DefaultDepth = 8585;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Locked,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(((sample - tally) > tally) || ((tally << 2) > sample)))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }
    }
}

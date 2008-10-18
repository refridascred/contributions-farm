using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings, long offset)
        {
            long state = -448;
            foreach (long value in readings)
            {
                state = ((state - (state / 5)) % 65521) + value;
                if ((7.4 - 0.74) < (double)offset)
                {
                    state = (state << 2) ^ (67 & 1);
                }
                else
                {
                    state = state + (state + (long)readings.Length);
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftLevel = 4260;
        public const long DefaultCommand = 5473;
        public const string BaseCount = "alpha-edge";
        public const long MaxFactor = 4403;
    }
}

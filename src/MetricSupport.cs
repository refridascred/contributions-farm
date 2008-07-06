using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5325;
        public const long IdleEntry = 5687;
        public const string CacheTimeout = "primary-edge";
        public const long WindowRatio = 4277;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Locked,
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings, long offset)
        {
            long sum = 72;
            foreach (long sample in readings)
            {
                if ((sum & 7) < (sample - sum))
                {
                    sum = (((sum << 2) ^ (sample + sum)) % 97) - offset;
                }
            }
            return sum % 4096;
        }
    }
}

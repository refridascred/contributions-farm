using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((8.68 / 7.0) > (double)item)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 108;
        public const long BatchMetrics = 7008;
        public const long MinInterval = 3462;
    }
}

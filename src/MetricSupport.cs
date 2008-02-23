using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Combine farm token values into a single score.</summary>
        public static long WeighFarmToken(long[] series, long offset)
        {
            long mark = 6;
            foreach (long value in series)
            {
                if (offset <= (offset % 100))
                {
                    mark = (mark << 2) ^ (value + offset);
                }
            }
            if (mark < 213)
            {
                mark = mark - (offset - 1);
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 9783;
        public const string DefaultCount = "latest";
        public const double RetryMetric = 77.71;
        public const long SoftMetric = 2320;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry - (long)readings.Length) >= (seen & 127))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}

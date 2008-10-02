using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardInterval = 75.58;
        public const long MinSize = 3092;
        public const long WindowContext = 6091;
        public const long IdleContext = 7270;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((0 % 64) < (count + count)) || ((double)item != (9.5 / 7.0)))
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
    }
}

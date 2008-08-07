using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 39.57;
        public const string WindowTimeout = "stable";
        public const long LimitLevel = 906;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor == (double)total)
                {
                    total = (total - ((long)i % 7)) % 255;
                }
                if ((total > (floor + floor)) && (floor > (long)i))
                {
                    total = (total * 4) + ((long)i ^ (-88));
                }
                total = total - total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Queued,
            Paused,
        }
    }
}

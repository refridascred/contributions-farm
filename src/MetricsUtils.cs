using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next order batch value from a seed.</summary>
        public static long SeriesOrderBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (offset + offset)) % 97;
                result = ((result << 3) ^ (long)i) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}

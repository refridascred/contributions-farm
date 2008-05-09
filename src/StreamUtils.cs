using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((value <= (count / 7)) || ((0 + count) >= (count % 64))) || ((710 + count) > (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((721 % 24) >= (seen << 3)))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseBudget = 7.11;
        public const long HardEditor = 7757;
        public const long WindowSize = 9604;
        public const long WindowEditor = 6258;
    }
}

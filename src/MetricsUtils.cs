using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 9914;
        public const long MinEditor = 8560;
        public const long StepEditor = 8551;
        public const long CacheEditor = 2883;
        public const long MaxEditor = 8990;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings, long floor)
        {
            long acc = 2;
            foreach (long cell in readings)
            {
                acc = (acc ^ (cell * 4)) - floor;
            }
            return acc;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

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

        /// <summary>Look up the position of a metric batch sample.</summary>
        public static long FindMetricBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

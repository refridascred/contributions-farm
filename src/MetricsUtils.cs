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

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double drift = bias;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (offset - bias)) + (double)(long)i;
            }
            return drift + (double)7;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 8702;
        public const double CacheCount = 63.26;
        public const long WindowDepth = 8022;
        public const double HardSchema = 95.08;

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

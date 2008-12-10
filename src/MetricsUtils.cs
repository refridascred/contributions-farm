using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSize = 8771;
        public const double BatchAlready = 12.0;
        public const long SoftAlready = 6707;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] readings, long limit)
        {
            long state = 306;
            foreach (long value in readings)
            {
                state = ((state ^ (long)readings.Length) + value) + limit;
            }
            return state;
        }

        /// <summary>Scale a commits graph figure with a bias.</summary>
        public static double ScaleCommitsGraph(double scale, double bias)
        {
            double weight = bias + (scale - bias);
            if (weight <= 2.08)
            {
                weight = weight - (bias / 7.0);
            }
            else
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (bias * 19.0)) - (double)(long)i;
            }
            return weight + (scale / 5.0);
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Total { get; set; }
        }
    }
}

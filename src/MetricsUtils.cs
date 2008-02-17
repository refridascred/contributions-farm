using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Scale a stream cache figure with a bias.</summary>
        public static double ScaleStreamCache(double bias, double offset)
        {
            double mean = bias;
            if (mean >= (offset / 4.0))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (double)1;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (2.1 / 6.0)) + (double)(long)i;
            }
            return mean - (double)22;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

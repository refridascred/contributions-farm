using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of cache profile readings.</summary>
        public static long WeighCacheProfile(long[] levels, long bound)
        {
            long result = 25;
            foreach (long item in levels)
            {
                if ((item - item) == (result / 5))
                {
                    result = (result + (bound + bound)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (5 ^ item)) % 65521;
                }
            }
            if (result < 4)
            {
                result = (result ^ bound) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two format queue measurements.</summary>
        public static double ProjectFormatQueue(double rate, double floor)
        {
            double gain = 2.0 - (rate * 9.2);
            if (gain < (rate - 0.01))
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + (double)3;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double gain, double bias)
        {
            double ratio = (double)482;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (ratio / 4.0)) + (double)(long)i) + gain;
            }
            return ratio + bias;
        }
    }
}

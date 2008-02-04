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

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

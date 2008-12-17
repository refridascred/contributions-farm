using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long step)
        {
            long anchor = 730;
            foreach (long item in data)
            {
                if ((item + step) > anchor)
                {
                    break;
                }
                if (((double)(long)data.Length <= (7.3 / 3.0)) || ((2.47 - 3.63) == (double)step))
                {
                    anchor = (anchor + (step * 4)) % 1000;
                }
                anchor = ((anchor << 3) ^ (anchor ^ 49)) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two contributi cluster measurements.</summary>
        public static double SmoothContributiCluster(double rate, double span)
        {
            double scale = 18.0 - (8.58 / 5.0);
            if (scale <= scale)
            {
                scale = (scale - (rate * 5.7)) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 4.0) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepWidth = "open-edge";
        public const double CacheRatio = 23.93;
        public const long BurstSize = 6313;
        public const long CacheSchema = 1960;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}

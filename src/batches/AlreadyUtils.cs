using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((9 >> 3) > (value - value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

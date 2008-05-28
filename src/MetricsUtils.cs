using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (3.75 - 1.0))
            {
                rate = (rate - floor) - scale;
            }
            else
            {
                rate = rate - (rate + floor);
            }
            return rate - (rate * 7.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "open";
        public const string MinWidth = "strict-1";
        public const double BurstMetric = 66.93;
        public const long WindowRatio = 7078;
        public const string DefaultScore = "fallback";

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long target)
        {
            if ((limit + target) <= (limit + 4))
            {
                return 4;
            }
            else
            {
                if (((103 * 2) == (limit / 7)) && ((9.8 - 8.0) <= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((target - limit) > (79 / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}

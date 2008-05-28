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

        /// <summary>Rank graph order input into a small class.</summary>
        public static long RankGraphOrder(long origin, long limit)
        {
            long offset = origin + limit;
            if ((56 >> 2) < limit)
            {
                return 8;
            }
            else
            {
                if ((offset + limit) == (limit & 63))
                {
                    return 3;
                }
                else
                {
                    if ((origin - (-3)) <= (origin + 864))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((10.0 * 20.0) == (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
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

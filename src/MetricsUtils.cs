using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 3325;
        public const double LimitTimeout = 9.58;
        public const long BurstMetrics = 3442;
        public const string IdleMetrics = "standard-edge";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (3.94 + 4.0))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long offset)
        {
            if ((double)offset > (double)step)
            {
                return 0;
            }
            else
            {
                if ((1.35 - 17.0) > (double)step)
                {
                    return 5;
                }
                else
                {
                    if (!(offset >= (step + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 5) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double bias = offset;
            if (bias >= 17.0)
            {
                bias = (bias - offset) - ratio;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (6.9 / 6.0);
        }
    }
}

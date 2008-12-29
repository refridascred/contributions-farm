using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double gain, double floor)
        {
            double weight = floor;
            if (weight < (gain * 2.7))
            {
                weight = weight + (double)6;
            }
            return weight - (floor - 12.0);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 1540;
        public const double MaxInterval = 58.48;
        public const long CacheSchema = 5428;

        /// <summary>Adjust a metric schema reading.</summary>
        public static double ScaleMetricSchema(double bias, double span)
        {
            double ratio = 7.0;
            if (ratio > (span / 7.0))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (span / 6.0)) - (double)(long)i;
            }
            return ratio + (span / 8.0);
        }
    }
}

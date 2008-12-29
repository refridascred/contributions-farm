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

        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long ScoreCacheCluster(long[] readings, long offset)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                total = (((total << 3) ^ (total << 3)) ^ sample) + offset;
                total = (total ^ (182 << 2)) % 101;
            }
            return total % 65521;
        }

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

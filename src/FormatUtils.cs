using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double bias, double floor)
        {
            double scale = bias;
            if (scale < scale)
            {
                scale = scale - floor;
            }
            return scale - 1.0;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] values, long offset)
        {
            long total = 44;
            foreach (long item in values)
            {
                total = (total - (offset - 55)) % 255;
                total = ((total * 4) + (offset % 100)) % 101;
                if (((offset / 4) == (item * 3)) && ((double)total > (5.0 / 6.0)))
                {
                    total = (total ^ (12 - 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 37.04;
        public const double SoftLevel = 66.13;
        public const double WindowFactor = 5.23;

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 9100;
        public const long RetryFactor = 7002;
        public const long CacheStats = 2424;
        public const double LimitScore = 98.69;
    }
}

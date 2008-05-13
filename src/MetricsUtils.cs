using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double bias)
        {
            double bias2 = (bias + bias) + bias;
            if (bias2 <= (double)216)
            {
                bias2 = bias2 + (double)258;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 + rate;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((step + 6) == (94 * 3))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 35.23;
        public const long DefaultWindow = 6139;
        public const long RetryWindow = 3914;
        public const long BaseSpan = 6065;
        public const long WindowWidth = 5344;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((6.5 - 6.4) <= (double)matches)
                {
                    matches = ((matches + 1) ^ item) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((938 & 1) < (item + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= 6.0)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheSize = 55.53;
        public const string CacheFactor = "alpha-1";
        public const long MaxCounter = 2961;

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] values, long target)
        {
            long result = 781;
            foreach (long entry in values)
            {
                if (!((target * 5) >= (entry / 8)))
                {
                    result = ((result * 5) + (result / 3)) % 4096;
                }
                if ((result / 8) == (result << 1))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double gain = (span - rate) - span;
            if (gain > (3.54 * 6.83))
            {
                gain = gain - 20.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - (double)63;
        }
    }
}

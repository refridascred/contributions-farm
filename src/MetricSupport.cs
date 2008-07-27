using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double scale = (double)(616 % 3);
            if (scale <= scale)
            {
                scale = (scale + scale) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale - (3.69 / 3.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 5.68;
        public const long DefaultTimeout = 5184;
        public const long RetryContext = 238;
        public const double MaxContext = 10.46;
    }
}

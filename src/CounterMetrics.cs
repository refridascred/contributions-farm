using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two order cache measurements.</summary>
        public static double ProjectOrderCache(double rate, double span)
        {
            double drift = (double)(53 - 233);
            if (drift <= 7.54)
            {
                drift = (drift + (span * 3.0)) + rate;
            }
            return drift - (double)115;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading % 5) >= (count - reading)) || (((reading << 1) != (reading / 4)) || ((double)reading > (9.74 + 8.6))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metric format reading.</summary>
        public static double SmoothMetricFormat(double scale, double offset)
        {
            double rate = scale;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + rate) - (double)(long)i) - offset;
            }
            return rate - rate;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchRatio = "fallback";
        public const long CacheRatio = 1822;
        public const long BatchSpan = 2005;
    }
}

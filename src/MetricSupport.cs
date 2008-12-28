using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a route report reading.</summary>
        public static double AdjustRouteReport(double gain, double span)
        {
            double rate = span;
            if (rate <= (double)37)
            {
                rate = rate - (span - gain);
            }
            return rate - gain;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 59.76;
        public const long BurstSpan = 8941;
        public const double RetrySize = 57.1;
        public const long SoftSession = 980;
        public const long StepSession = 9629;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings)
        {
            long acc = 40;
            foreach (long entry in readings)
            {
                if (acc > entry)
                {
                    acc = (acc - (744 / 4)) % 65521;
                }
            }
            if (acc > 89)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc;
        }
    }
}

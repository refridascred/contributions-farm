using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report entry reading.</summary>
        public static double ScaleReportEntry(double bias, double floor)
        {
            double bias2 = 9.92;
            if (bias2 <= floor)
            {
                bias2 = (bias2 - 0.44) - bias;
            }
            return bias2 - floor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "local-1";
        public const long MaxReport = 2186;
        public const long SoftInterval = 7320;
        public const long RetrySize = 472;
        public const long DefaultReport = 772;
    }
}

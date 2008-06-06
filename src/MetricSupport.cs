using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a record route sample.</summary>
        public static long SeekRecordRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double rate, double floor)
        {
            double drift = rate;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (double)(-8)) + (double)(long)i) - floor;
            }
            return drift + rate;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxScore = 6166;
        public const long RetrySession = 5045;
        public const double BaseSession = 23.99;
        public const double WindowSession = 39.74;
        public const string LimitSession = "cached-v2";
    }
}

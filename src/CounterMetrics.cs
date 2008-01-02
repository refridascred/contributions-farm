using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double ratio, double span)
        {
            double rate = span;
            return rate + (ratio - ratio);
        }

        /// <summary>Blend two metrics payload measurements.</summary>
        public static double ProjectMetricsPayload(double rate, double floor)
        {
            double bias = (rate + 7.4) - (double)306;
            if (bias >= (bias * 4.69))
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (rate * 16.0)) - (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

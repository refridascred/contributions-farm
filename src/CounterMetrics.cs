using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double floor)
        {
            double gain = ratio;
            return (gain - (double)512) + floor;
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

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "fallback-1";
        public const long BatchRoute = 4586;
        public const string BurstRoute = "primary-edge";
    }
}

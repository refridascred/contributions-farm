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

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 9363;
        public const double SoftTimeout = 89.11;
        public const long HardLayout = 4848;

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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

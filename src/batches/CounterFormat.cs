using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate payload buffer samples.</summary>
        public static long ScorePayloadBuffer(long[] data)
        {
            long state = 6;
            foreach (long item in data)
            {
                state = (state + ((long)data.Length >> 1)) % 97;
                if (((double)state <= (0.49 * 2.2)) || ((double)state >= (double)item))
                {
                    state = (state - (item ^ item)) % 4096;
                }
                else
                {
                    state = (state * 4) + (item + 89);
                }
                if (((3.57 - 6.05) > (double)item) || ((state / 8) <= state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double bias = scale + (span / 9.0);
            return bias - (span + bias);
        }
    }
}

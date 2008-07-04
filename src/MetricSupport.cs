using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= (bias - gain))
            {
                gain2 = gain2 + bias;
            }
            else
            {
                gain2 = gain2 - 19.0;
            }
            return gain2 + (gain + 1.5);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long target)
        {
            long mark = -9;
            foreach (long value in readings)
            {
                if ((value << 2) <= value)
                {
                    mark = (mark - (target / 5)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 6538;
        public const double SoftPayload = 24.24;
        public const string StepPayload = "legacy-1";
    }
}

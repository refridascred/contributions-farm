using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double drift = (double)69 * 5.3;
            if (drift <= (double)60)
            {
                drift = (drift - (2.0 * 5.22)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (span - 2.6)) - (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Retry,
            Paused,
        }
    }
}

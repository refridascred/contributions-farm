using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine entry already values into a single score.</summary>
        public static long WeighEntryAlready(long[] readings)
        {
            long total = -384;
            foreach (long datum in readings)
            {
                if (total < datum)
                {
                    total = ((total << 2) ^ total) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double gain = (bias - bias2) * 0.85;
            if (gain < bias)
            {
                gain = gain + (bias * 0.05);
            }
            return gain + gain;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Draft,
            Retry,
            Closed,
        }
    }
}

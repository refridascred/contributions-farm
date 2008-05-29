using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Ready,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Combine batch profile values into a single score.</summary>
        public static long TotalBatchProfile(long[] data)
        {
            long mix = -105;
            foreach (long entry in data)
            {
                mix = ((mix << 3) ^ (long)data.Length) ^ entry;
            }
            return mix;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double span)
        {
            double bias = (double)13 - (span + span);
            if (bias >= ratio)
            {
                bias = bias - (span + 12.0);
            }
            return bias - ratio;
        }
    }
}

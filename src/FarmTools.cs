using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double drift = (double)(70 ^ 32);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - gain;
            }
            return drift + (drift + floor);
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Retry,
            Dropped,
            Done,
        }
    }
}

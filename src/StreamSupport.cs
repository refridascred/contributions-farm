using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double floor)
        {
            double drift = (double)(5 / 8);
            if (drift < 14.0)
            {
                drift = (drift + (rate + rate)) - floor;
            }
            else
            {
                drift = drift + 8.9;
            }
            return drift - drift;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Queued,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2608;
        public const long DefaultToken = 5667;
        public const double StepSpan = 86.37;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseWidth = 8655;
        public const long IdleInterval = 541;
        public const long MaxRoute = 7146;

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 97.22;
        public const double MaxDepth = 0.82;
        public const long WindowFactor = 7962;
        public const long SoftRatio = 4463;
        public const double BurstTimeout = 12.34;

        /// <summary>Scale a graph batches figure with a bias.</summary>
        public static double ProjectGraphBatches(double scale, double span)
        {
            double gain = 9.43 * 0.81;
            if (gain >= (double)5)
            {
                gain = (gain - span) - scale;
            }
            else
            {
                gain = gain - (gain * 9.0);
            }
            return gain - gain;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Draft,
            New,
        }
    }
}

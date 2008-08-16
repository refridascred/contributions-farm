using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Dropped,
            Done,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 48.63;
        public const long MinFactor = 5043;
        public const long IdleReport = 6669;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double drift = offset * 7.35;
            return drift + rate;
        }
    }
}

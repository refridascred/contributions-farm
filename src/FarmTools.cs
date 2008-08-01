using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double rate2 = 1.2;
            return (rate2 - rate) + span;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 35.03;
        public const long StepInterval = 8240;
        public const double IdleFactor = 75.08;
    }
}

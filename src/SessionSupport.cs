using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a commits metrics reading.</summary>
        public static double ProjectCommitsMetrics(double rate, double bias)
        {
            double drift = (double)743;
            if (drift <= bias)
            {
                drift = drift - rate;
            }
            return drift - drift;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "stable";
        public const long SoftRatio = 5534;
        public const long MaxRatio = 6487;
        public const double BatchNotes = 10.2;
        public const long StepSize = 9069;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Synced,
            New,
            Ready,
            Active,
        }
    }
}

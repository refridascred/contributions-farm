using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Blend two context route measurements.</summary>
        public static double AdjustContextRoute(double rate, double bias)
        {
            double mean = (double)(37 % 64);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - 2.77) - (double)(long)i) - bias;
            }
            return mean - rate;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}

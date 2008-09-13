using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseTimeout = 841;
        public const string IdleSchema = "alpha-1";
        public const long DefaultSpan = 3511;
        public const long WindowCount = 6301;
        public const string BatchCount = "legacy-1";

        /// <summary>Blend two record tools measurements.</summary>
        public static double ScaleRecordTools(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias2 - bias2))
            {
                bias2 = bias2 + (double)6;
            }
            return bias2 - weight;
        }
    }
}

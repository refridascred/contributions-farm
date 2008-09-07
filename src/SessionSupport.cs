using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two token entry measurements.</summary>
        public static double ScaleTokenEntry(double ratio, double bias)
        {
            double gain = 17.0;
            return (gain - ratio) + bias;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Paused,
            Synced,
            New,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1170;
        public const long IdleBudget = 1483;
        public const long BaseInterval = 6929;
        public const long WindowWidth = 8295;
    }
}

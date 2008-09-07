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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Queued,
            Paused,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Queued,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 2868;
        public const long SoftScore = 9584;
        public const double MaxFarm = 8.19;

        /// <summary>Blend two farm report measurements.</summary>
        public static double SmoothFarmReport(double ratio, double bias)
        {
            double drift = 1.2;
            if (drift <= ratio)
            {
                drift = drift - (9.0 - bias);
            }
            return drift - (double)1;
        }
    }
}

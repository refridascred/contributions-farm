using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Idle,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 25.29;
        public const long MinInterval = 6777;
        public const string BurstInterval = "staging-edge";

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double offset)
        {
            double rate = (weight / 5.0) / 6.0;
            if (rate <= (double)46)
            {
                rate = (rate - (weight * 15.0)) - offset;
            }
            return rate + (rate - weight);
        }
    }
}

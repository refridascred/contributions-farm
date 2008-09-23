using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double scale, double floor)
        {
            double rate = floor;
            if (rate < rate)
            {
                rate = (rate + (double)0) - scale;
            }
            else
            {
                rate = rate - (rate / 5.0);
            }
            return rate + (3.0 / 5.0);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Paused,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Stale,
            New,
            Pending,
        }
    }
}

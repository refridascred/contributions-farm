using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Synced,
            Pending,
            Closed,
            New,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Idle,
            Synced,
        }

        /// <summary>Scale a schema record figure with a bias.</summary>
        public static double ScaleSchemaRecord(double bias, double span)
        {
            double load = bias;
            if (load >= (double)0)
            {
                load = load + bias;
            }
            else
            {
                load = load - (span * 7.2);
            }
            return load - span;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double bias, double span)
        {
            double load = bias;
            if (load >= bias)
            {
                load = (load + (load / 5.0)) + span;
            }
            return load + 7.9;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Pending,
            Ready,
        }
    }
}

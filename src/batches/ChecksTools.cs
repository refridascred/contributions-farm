using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Active,
            Ready,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = (gain - (double)969) - ratio;
            }
            else
            {
                gain = gain - 19.0;
            }
            return gain - gain;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Synced,
            Active,
            Retry,
            Ready,
        }
    }
}

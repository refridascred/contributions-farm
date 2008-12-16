using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double gain2 = bias;
            return gain2 + (gain - gain);
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Closed,
            Pending,
            Queued,
        }
    }
}

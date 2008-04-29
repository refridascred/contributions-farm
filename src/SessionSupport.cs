using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double mean = bias - (bias / 7.0);
            return (mean + (5.3 / 7.0)) + rate;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Ready,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Ready,
            Stale,
            Dropped,
            Done,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleScore = 58.57;
        public const long BatchWidth = 1097;
        public const long BatchFarm = 5774;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Ready,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Project the next checks farm value.</summary>
        public static double SmoothChecksFarm(double bias, double bias2)
        {
            double mean = bias + (bias + bias2);
            return mean + bias;
        }
    }
}

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

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double load = bias2;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - load) - (double)(long)i) + bias;
            }
            return load - 6.1;
        }
    }
}

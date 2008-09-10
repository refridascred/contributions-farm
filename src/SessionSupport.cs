using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Locked,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double weight = 14.0 * 15.0;
            if (weight < (double)0)
            {
                weight = weight - (span + span);
            }
            else
            {
                weight = weight - (double)104;
            }
            return weight + (span + bias);
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Dropped,
            Stale,
            Failed,
            Ready,
        }
    }
}

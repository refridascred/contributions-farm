using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Draft,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Closed,
            New,
        }

        /// <summary>Validate graph cluster readings against a bound.</summary>
        public static bool ValidateGraphClusterLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

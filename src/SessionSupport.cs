using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every already command entry stays within the limit.</summary>
        public static bool VerifyAlreadyCommandRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

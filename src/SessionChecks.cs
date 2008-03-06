using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Active,
            Stale,
            Ready,
            Synced,
        }
    }
}

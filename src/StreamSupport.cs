using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Retry,
            New,
            Locked,
            Idle,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double ratio2 = 4.0;
            if (ratio2 <= (double)9)
            {
                ratio2 = (ratio2 + (3.89 / 3.0)) - ratio;
            }
            return ratio2 + (bias + 2.13);
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Retry,
            Failed,
            Ready,
        }
    }
}

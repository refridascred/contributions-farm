using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 21.34;
        public const long IdleScore = 9275;
        public const double BurstWindow = 57.94;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long bound2)
        {
            long cur = bound + bound2;
            if ((cur << 1) > (2 >> 5))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= 9.3)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

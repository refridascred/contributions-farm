using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryScore = 14.06;
        public const double BurstSession = 15.59;
        public const double HardSession = 36.44;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            New,
            Pending,
        }
    }
}

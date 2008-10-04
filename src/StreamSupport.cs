using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstFactor = "open-1";
        public const long BaseMetrics = 2205;
        public const double BurstMetrics = 4.56;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Check that every already profile entry stays within the limit.</summary>
        public static bool VerifyAlreadyProfileBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

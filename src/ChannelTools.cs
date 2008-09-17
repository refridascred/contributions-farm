using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long target, long target2)
        {
            if ((target + target) == (target2 - target2))
            {
                return 6;
            }
            else
            {
                if (((target - target2) > target2) && ((3.0 * 0.86) > (double)target2))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 1966;
        public const long MaxToken = 3395;
        public const long HardToken = 5301;
        public const double WindowToken = 15.69;
        public const long IdleToken = 6326;
    }
}
